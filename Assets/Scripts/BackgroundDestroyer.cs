using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroyer : MonoBehaviour
{
    public GameObject DestroyPoint;


    void Start()
    {
        DestroyPoint = GameObject.Find("BGdestrPoint");
    }


    void Update()
    {
        if (transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
