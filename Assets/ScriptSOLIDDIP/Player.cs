using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {
        Debug.Log("El jugador a realizado un Emoji");
    }

    public void ButtonActionB()
    {
        Debug.Log("El jugador se ha agachado");
    }
}
