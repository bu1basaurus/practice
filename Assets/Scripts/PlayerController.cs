using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   // Transform Trans;

    public float moveSpeed;
    public float jumpForce;

    Rigidbody2D rb;
    Collider2D Mycollider; 

    public bool isGrounded;
   // public bool CanStand;

    public LayerMask WhatIsGround;
   // public LayerMask WhatIsFloor; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);
        //CanStand = Physics2D.IsTouchingLayers(Mycollider, WhatIsFloor); 
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

        }
        
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.3f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.5f);
        }  */
    }

}

