using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    int R, G, B;

    public Text RedText, GreenText, BlueText;


    public void RedSliderValue(Slider valRed)
    {
        RedText.text = valRed.value.ToString();
        Debug.Log(valRed.value);

    }

    public void GreenSliderValue(Slider valGreen)
    {
        GreenText.text = valGreen.value.ToString();
        Debug.Log(valGreen.value);
    }
    public void BlueSliderValue(Slider valBlue)
    {
        BlueText.text = valBlue.value.ToString();
        Debug.Log(valBlue.value);

    }


}
