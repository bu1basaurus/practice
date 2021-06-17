using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelmenGen : MonoBehaviour
{
    public GameObject obj;
    public Transform GenerationPoint;
    public int DBmin;
    public int DBmax;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        int DistanceBetween = Random.Range(DBmin, DBmax);
        if (transform.position.x < GenerationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + DistanceBetween, obj.transform.position.y, obj.transform.position.z);
            Instantiate(obj, transform.position, obj.transform.rotation);
        }
    }
}
