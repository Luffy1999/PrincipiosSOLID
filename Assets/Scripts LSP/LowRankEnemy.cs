using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowRankEnemy : Enemy
{
    private void Start()
    {
        enemyName = "Enemigo de Bajo Rango";
        health = 100;
    }

    public virtual void Move()
    {
        Debug.Log(enemyName + " se esta moviendo.");

    }

    public virtual void Attack()
    {
        Debug.Log(enemyName + " esta atacando");
    }
}
