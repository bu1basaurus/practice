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
    public GameObject Panel;

    public bool isGrounded;
    public static bool isImmortal;
    public static bool Alive;


    public LayerMask WhatIsGround;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
        isImmortal = false;
        Score.ScoreCount = 0;
        Alive = true;
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
        if (Input.GetKeyDown(KeyCode.Space) && CollectPelmen.pelmenCount >= 25 && isImmortal==false)
        {
            StartCoroutine(Shield());
            CollectPelmen.pelmenCount -= 25;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Respawn") && isImmortal==false)
        {
            Panel.SetActive(true);
            gameObject.SetActive(false);
            Alive = false;
            if(PlayerPrefs.GetInt("Record1")<Score.ScoreCount)
            {
                PlayerPrefs.SetInt("Record5", PlayerPrefs.GetInt("Record4"));
                PlayerPrefs.SetInt("Record4", PlayerPrefs.GetInt("Record3"));
                PlayerPrefs.SetInt("Record3", PlayerPrefs.GetInt("Record2"));
                PlayerPrefs.SetInt("Record2", PlayerPrefs.GetInt("Record1"));

                PlayerPrefs.SetInt("Record1", Score.ScoreCount);
            }
            else if (PlayerPrefs.GetInt("Record2") < Score.ScoreCount)
            {
                PlayerPrefs.SetInt("Record5", PlayerPrefs.GetInt("Record4"));
                PlayerPrefs.SetInt("Record4", PlayerPrefs.GetInt("Record3"));
                PlayerPrefs.SetInt("Record3", PlayerPrefs.GetInt("Record2"));

                PlayerPrefs.SetInt("Record2", Score.ScoreCount);
            }
            else if (PlayerPrefs.GetInt("Record3") < Score.ScoreCount)
            {
                PlayerPrefs.SetInt("Record5", PlayerPrefs.GetInt("Record4"));
                PlayerPrefs.SetInt("Record4", PlayerPrefs.GetInt("Record3"));

                PlayerPrefs.SetInt("Record3", Score.ScoreCount);
            }
            else if (PlayerPrefs.GetInt("Record4") < Score.ScoreCount)
            {
                PlayerPrefs.SetInt("Record5", PlayerPrefs.GetInt("Record4"));

                PlayerPrefs.SetInt("Record4", Score.ScoreCount);
            }
            else if (PlayerPrefs.GetInt("Record5") < Score.ScoreCount)
            {
                PlayerPrefs.SetInt("Record5", Score.ScoreCount);
            }
        }
        if (collision.tag.Equals("pelmen"))
        {
            CollectPelmen.pelmenCount += 1;
            Destroy(collision.gameObject);
        }
        if(collision.tag.Equals("shield"))
        {
            StartCoroutine(Shield());
            Destroy(collision.gameObject);
        }

    }

    private IEnumerator Shield()
    {
        isImmortal = true;
        yield return new WaitForSeconds(7);
        isImmortal = false;

    }


}

