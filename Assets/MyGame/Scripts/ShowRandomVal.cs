using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRandomValue : MonoBehaviour
{

    public Text guiTextRandomVal;
    public MyScriptableObject myData;

    public void GetRandomVal()
    {
        float rndVal = Random.Range(1.0f, 10.0f);
        guiTextRandomVal.text = rndVal.ToString();
        myData.randomVal = rndVal;
        myData.test = "Lukas";
    }
}