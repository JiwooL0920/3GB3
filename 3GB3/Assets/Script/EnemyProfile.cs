using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyProfile : ScriptableObject {
    public int health;
    public int charmHealth;

    public Sprite EnemyVisual;

    public GameObject[] enemyAttacks;
}