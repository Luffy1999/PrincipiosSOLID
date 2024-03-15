using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Implementacion : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        Botones Botones = FindAnyObjectByType<Botones>();

        Player player = FindAnyObjectByType<Player>();
        Botones.SetAction(player);

        Botones.OnActionA();
        Botones.OnActionB();


        Vehiculo vehiculo = FindAnyObjectByType<Vehiculo>();

        Botones.SetAction(vehiculo);

        Botones.OnActionA();
        Botones.OnActionB();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
