using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {
        Debug.Log("Se a cambiado a la siguiente estación de radio");
    }

    public void ButtonActionB()
    {
        Debug.Log("Se a cambiado a la anterior estación de radio");
    }
}
