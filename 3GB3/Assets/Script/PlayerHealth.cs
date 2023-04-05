using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public int maxHealth;
    public TMPro.TMP_Text uiPlayerHealth;
    public GameObject OverScreen;
    public GameObject WinningScreen;

    public void OnHit(int dmg) {
        health-= dmg;
        uiPlayerHealth.text = health.ToString();
        if(health <= 0) {
            IsDie();
        }
    }

    public void IsDie() {
       //SceneManager.LoadScene("Room_afterwork"); 
       if (!WinningScreen.active){
            OverScreen.SetActive(true);
       }
    }
}