using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    public float moveSpeed;
    public float jumpForce;

    Rigidbody2D rb;
    Collider2D Mycollider; 

    public bool isGrounded;
    public static bool isImmortal;


    public LayerMask WhatIsGround;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
        isImmortal = false;
    }

    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(1))
        {
            transform.localScale = new Vector2(2.7f, 1.2f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)|| Input.GetMouseButtonUp(1))
        {
            transform.localScale = new Vector2(1.7f, 1.7f);
        }  

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Respawn") && isImmortal==false)
        {
            SceneManager.LoadScene(0);
        }
        if (collision.tag.Equals("pelmen"))
        {
            CollectPelmen.pelmenCount += 1;
            Destroy(collision.gameObject);
        }
        if(collision.tag.Equals("shield"))
        {
            StartCoroutine(shield());
            Destroy(collision.gameObject);
        }

    }

    private IEnumerator shield()
    {
        isImmortal = true;
        yield return new WaitForSeconds(7);
        isImmortal = false;

    }


}

