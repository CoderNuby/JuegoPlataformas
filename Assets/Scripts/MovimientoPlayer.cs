using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private Transform _transform;
    private int Direccion = 0;

    public float Velocidad = 3f;
    public float JumpImpulse = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && CheckGround.isGrounded)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, JumpImpulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Direccion = 1;
            _transform.localScale = new Vector3(Direccion, _transform.localScale.y, _transform.localScale.z);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Direccion = -1;
            _transform.localScale = new Vector3(Direccion, _transform.localScale.y, _transform.localScale.z);
        }
        else
        {
            Direccion = 0;
        }

        _rigidbody2D.velocity = new Vector2(Velocidad * Direccion, _rigidbody2D.velocity.y);

        if (!CheckGround.isGrounded)
        {
            isIdleAnimator(false);
            isWalkingAnimator(false);
            isJumpingAnimator(true);
        }
        else if(_rigidbody2D.velocity.x == 0 && Direccion == 0)
        {
            isJumpingAnimator(false);
            isWalkingAnimator(false);
            isIdleAnimator(true);
        }
        else
        {
            isIdleAnimator(false);
            isJumpingAnimator(false);
            isWalkingAnimator(true);
        }
    }

    private void isIdleAnimator(bool valor)
    {
        _animator.SetBool("isIdle", valor);
    }

    private void isWalkingAnimator(bool valor)
    {
        _animator.SetBool("isWalking", valor);
    }

    private void isJumpingAnimator(bool valor)
    {
        _animator.SetBool("isJumping", valor);
    }
}
