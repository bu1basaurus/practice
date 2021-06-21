using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public Text scoreT;


    void Start()
    {
        scoreT.text = "��� ����: "  + Score.ScoreCount.ToString();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            SceneManager.LoadScene(1);
 
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
}
