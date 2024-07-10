using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Movement
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    public Vector2 input;
    Animator anim;
    private Vector2 lastMoveDirection;
    //private bool facingLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Animate();
    }

/// This is needed because Update() is Frame rate dependent and FixedUpdate() is Frame rate independent
    private void FixedUpdate()
    {
        rb.velocity = input * moveSpeed;
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if((moveX == 0 && moveY == 0) && (input.x != 0 || input.y != 0))
        {
            lastMoveDirection = input;
        }

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();
    }

    void Animate()
    {
        anim.SetFloat("MoveX", input.x);
        anim.SetFloat("MoveY", input.y);
        anim.SetFloat("MoveMagnitude", input.magnitude);
        anim.SetFloat("LastMoveX", lastMoveDirection.x);
        anim.SetFloat("LastMoveY", lastMoveDirection.y);
        // bool isMoving = input.x != 0 || input.y != 0;

        // anim.SetFloat("MoveX", input.x);
        // anim.SetFloat("MoveY", input.y);
        // anim.SetFloat("MoveMagnitude", input.magnitude);

        // if (isMoving)
        // {
        //     anim.SetFloat("LastMoveX", input.x);
        //     anim.SetFloat("LastMoveY", input.y);
        // }
        // else
        // {
        //     anim.SetFloat("MoveX", 0);
        //     anim.SetFloat("MoveY", 0);
        //     anim.SetFloat("MoveMagnitude", 0);
        // }
    }

    void Flip()
    {

    }
}
