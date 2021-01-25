using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRandomVal : MonoBehaviour
{
    public MyScriptableObject myData;
    public Text randomValText;
    public void LoadRandomValue()
    {
        randomValText.text = myData.randomVal.ToString();
    }
}