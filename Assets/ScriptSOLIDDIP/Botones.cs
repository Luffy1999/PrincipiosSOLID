using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    private IButtonBehavior buttonBehavior;

    public void SetAction(IButtonBehavior Action)
    {
        this.buttonBehavior = Action;
    }

    public void OnActionA()
    {
        buttonBehavior.ButtonActionA();
    }

    public void OnActionB()
    {
        buttonBehavior.ButtonActionB();
    }
}
