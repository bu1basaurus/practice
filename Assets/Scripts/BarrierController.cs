using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierController : MonoBehaviour
{
    public float Movespeed;
    bool MovingUp = true;



    void Update()
    {
        if (transform.position.y > 3f)
        {
            MovingUp = false;
        }
        else if (transform.position.y < -2.5f)
        {
            MovingUp = true;
        }

        if (MovingUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Movespeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Movespeed * Time.deltaTime);
        }
    }
}
