using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyingText : MonoBehaviour
{
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectPelmen.pelmenCount>=25)
            timerText.text = "Нажмите пробел чтобы купить бустер";
        else timerText.text = "";
    }
}
