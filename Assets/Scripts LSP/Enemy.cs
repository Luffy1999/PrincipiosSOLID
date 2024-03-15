using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int health;

    public virtual void Move()
    {
        Debug.Log(enemyName + " se esta moviendo.");

    }

    public virtual void Attack()
    {
        Debug.Log(enemyName + " esta atacando");
    }
}
