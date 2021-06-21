using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int ScoreCount;
    private Text ScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.Alive == true)
        ScoreCount+=1;
        ScoreCounter.text = ScoreCount.ToString();
    }
}
