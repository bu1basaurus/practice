using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject DestroyPoint;


    void Start()
    {
       DestroyPoint = GameObject.Find("PFdestrPoint");
    }
  

    void Update()
    {
        if(transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
