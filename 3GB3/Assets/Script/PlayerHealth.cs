using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public int maxHealth;
    public TMPro.TMP_Text uiPlayerHealth;

    public void OnHit(int dmg) {
        health-= dmg;
        uiPlayerHealth.text = health.ToString();
        if(health <= 0) {
            IsDie();
        }
    }

    public void IsDie() {

    }
}