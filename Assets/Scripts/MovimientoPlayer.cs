using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float Velocidad = 1f;
    public int Direccion = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Direccion = 1;
        }else if (Input.GetKey(KeyCode.A))
        {
            Direccion = -1;
        }
        else
        {
            Direccion = 0;
        }
        rb2d.velocity = new Vector2(Velocidad * Direccion, rb2d.velocity.y);
    }
}
