using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDestroyer : MonoBehaviour
{
    public GameObject DestroyPoint;


    void Start()
    {
        DestroyPoint = GameObject.Find("BRdestrPoint");
    }


    void Update()
    {
        if (transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
