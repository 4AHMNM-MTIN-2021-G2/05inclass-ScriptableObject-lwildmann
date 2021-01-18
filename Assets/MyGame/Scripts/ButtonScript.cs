using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{
    public float Number;
    public Text Value;

    public void ValueButton ()
    {
        Number = UnityEngine.Random.value;
        Value.text = Number.ToString();
        Debug.Log("Ich werde gedrückt.");
    }
}
