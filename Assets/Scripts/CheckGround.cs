using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }
}
