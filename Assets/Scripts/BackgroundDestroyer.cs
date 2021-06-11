using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroyer : MonoBehaviour
{

    public GameObject DestroyPoint;

    // Start is called before the first frame update
    void Start()
    {
        DestroyPoint = GameObject.Find("BGdestrPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < DestroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
