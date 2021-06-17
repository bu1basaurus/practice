using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objects;
    public Transform GenerationPoint;
    public int DBmin;
    public int DBmax;



    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(0, objects.Length);
        int DistanceBetween = Random.Range(DBmin, DBmax);
        if (transform.position.x < GenerationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + DistanceBetween, objects[rand].transform.position.y, objects[rand].transform.position.z);
            Instantiate(objects[rand], transform.position, objects[rand].transform.rotation);
        }
    }
}
