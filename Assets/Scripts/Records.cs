using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Records : MonoBehaviour
{
    public Text Record1;
    public Text Record2;
    public Text Record3;
    public Text Record4;
    public Text Record5;
    void Start()
    {
        Record1.text = "�1 - " + PlayerPrefs.GetInt("Record1").ToString();
        Record2.text = "�2 - " + PlayerPrefs.GetInt("Record2").ToString();
        Record3.text = "�3 - " + PlayerPrefs.GetInt("Record3").ToString();
        Record4.text = "�4 - " + PlayerPrefs.GetInt("Record4").ToString();
        Record5.text = "�5 - " + PlayerPrefs.GetInt("Record5").ToString();
    }


}
