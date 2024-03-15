using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _PlayerSpeed;
    public float _JumpForce;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // declaraci�n de inputs para el movimiento horizontal
        float Hmove = Input.GetAxis("Horizontal");

        // Programaci�n del movimiento
        Vector2 _Direction = new Vector2(Hmove, 0f) * _PlayerSpeed * Time.deltaTime;

        // Programaci�n del salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * _JumpForce);
        }
    }
}
