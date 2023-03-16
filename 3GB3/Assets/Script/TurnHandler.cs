using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState {
    START,
    PLAYER,
    ENEMY,
    END,
    WIN,
    LOSE
}

public class TurnHandler : MonoBehaviour {
    public BattleState state;
    
    public EnemyProfile[] enemies;
    private bool enemyActed;
    private GameObject[] enemyAttacks;

    public GameObject PlayerUI;
    public PlayerControl PlayerControl;

    void Start() {
        Time.timeScale = 0;
        state = BattleState.START;
        enemyActed = false;
    }

    void Update() {
        if(state == BattleState.START) {
            PlayerUI.SetActive(true);
            state = BattleState.PLAYER;
        } else if(state == BattleState.PLAYER) {

        } else if (state == BattleState.ENEMY) {
            if(enemies.Length <= 0) {
                EnemyFinish();
            } else {
                if(!enemyActed) {
                    PlayerControl.gameObject.SetActive(true);
                    PlayerControl.SetPos();

                    foreach(EnemyProfile enemy in enemies) {
                        int atk = Random.Range(0, enemy.enemyAttacks.Length);
                        Instantiate(enemy.enemyAttacks[atk], Vector3.zero, Quaternion.identity);
                    }

                    enemyAttacks = GameObject.FindGameObjectsWithTag("Enemy");
                    enemyActed = true;
                } else {
                    bool enemyEnd = true;
                    foreach(GameObject enemy in enemyAttacks) {
                        if(!enemy.GetComponent<EnemyTurnHandle>().isFinished) {
                            enemyEnd = false;
                        }
                    }

                    if(enemyEnd) {
                        EnemyFinish();
                    }
                }
            }
        } else if (state == BattleState.END) {
            PlayerControl.gameObject.SetActive(false);

            if(PlayerControl.GetComponent<PlayerHealth>().health < 0) {
                state = BattleState.LOSE;
            } {
                state = BattleState.START;
            }
        }
    }

    public void PlayerAct() {
        Time.timeScale = 1f;
        PlayerFinish();
    }

    void PlayerFinish() {
        PlayerUI.SetActive(false);

        state = BattleState.ENEMY;
    }

    void EnemyFinish() {
        foreach(GameObject obj in enemyAttacks) {
            Destroy(obj);
        }

        enemyActed = false;

        state = BattleState.END;
    }
}