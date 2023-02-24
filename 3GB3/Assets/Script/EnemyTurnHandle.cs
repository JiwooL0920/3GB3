using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnHandle : MonoBehaviour {
    public bool isFinished;

    public int attack;

    private void Start() {
        isFinished = false;
        GetComponent<Animator>().SetInteger("Attack", Random.Range(0, attack));
    }

    public void AttackDone() {
        isFinished = true;
    }
}