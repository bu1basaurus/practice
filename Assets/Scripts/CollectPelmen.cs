using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPelmen : MonoBehaviour
{

    public static int pelmenCount;
    private Text pelmenCounter;

    // Start is called before the first frame update
    void Start()
    {
        pelmenCounter = GetComponent<Text>();
        pelmenCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pelmenCounter.text = pelmenCount.ToString();
    }
}
