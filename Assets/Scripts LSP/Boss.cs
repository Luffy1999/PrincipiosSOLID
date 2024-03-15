using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    private void Start()
    {
        enemyName = "Jefe";
        health = 200;
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
