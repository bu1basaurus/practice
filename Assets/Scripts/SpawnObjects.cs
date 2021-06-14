using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objects;

    void Start()
    {
       // int rand = Random.Range(0, objects.Length);
        // Instantiate(objects[rand], objects[rand].transform.position, objects[rand].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], objects[rand].transform.position, objects[rand].transform.rotation);
    }
}
