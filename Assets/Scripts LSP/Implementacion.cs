using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Implementacion : MonoBehaviour
{
    
    
    void Start()
    {
        Enemy minion = new Enemy();
        minion.Move();
        Debug.Log(minion + " se esta moviendo.");
        Enemy maxion = new LowRankEnemy();
        maxion.Move();
        Enemy bestEnemy = new Boss();
        bestEnemy.Move();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
