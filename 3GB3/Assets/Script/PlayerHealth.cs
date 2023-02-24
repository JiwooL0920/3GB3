using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public int maxHealth;

    public void OnHit(int dmg) {
        health-= dmg;
        if(health <= 0) {
            IsDie();
        }
    }

    public void IsDie() {

    }
}