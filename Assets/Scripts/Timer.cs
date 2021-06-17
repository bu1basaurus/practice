using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float time = 7;
    private Text timerText;


    void Start()
    {
        timerText = GetComponent<Text>();
        timerText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.isImmortal == true)
        {
            time -= Time.deltaTime;
            timerText.text = (Mathf.Round(time)).ToString();
        }
        else
        {
            timerText.text = "";
            time = 7;
        }


    }
}
