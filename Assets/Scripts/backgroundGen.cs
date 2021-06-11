using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundGen : MonoBehaviour
{

    public GameObject Background;
    public Transform BGgenPoint;
    public float DistanceBetween;

    float BackgroundWidth;


    // Start is called before the first frame update
    void Start()
    {
        BackgroundWidth = 96;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < BGgenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + BackgroundWidth, transform.position.y, transform.position.z);

            Instantiate(Background, transform.position, transform.rotation);

        }
    }
}
