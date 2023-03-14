using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    float R, G, B;

    public Text RedText, GreenText, BlueText;

    public GameObject[] Buttons;


    public void RedSliderValue(Slider valRed)
    {
        RedText.text = valRed.value.ToString();
        R = valRed.value;


    }

    public void GreenSliderValue(Slider valGreen)
    {
        GreenText.text = valGreen.value.ToString();
        G = valGreen.value;
    }
    public void BlueSliderValue(Slider valBlue)
    {
        BlueText.text = valBlue.value.ToString();
        B = valBlue.value;
    }


    public void ValUpdate()
    {
        foreach (var item in Buttons)
        {
            if(item.transform.GetChild(0).gameObject.activeSelf == true)
            {
                item.transform.GetChild(0).GetComponent<Image>().color = new Color(R / 100, G / 100, B / 100);
            }
            

        }
        Debug.Log("Red: " + R + " Blue: " + B + " Green:" + G);
       
    }

    public void ValSave()
    {

    }


}
