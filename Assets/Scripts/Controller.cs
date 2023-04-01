using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;

public class Controller : MonoBehaviour
{
    float R, G, B, D;

    public Text RedText, GreenText, BlueText, DelayText;

    public GameObject[] Buttons;

    private DatabaseReference MyDBreference;

    private void Start()
    {
        MyDBreference = FirebaseDatabase.DefaultInstance.RootReference;
    }
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

    public void DelaySliderValue(Slider valDelay)
    {
        DelayText.text = valDelay.value.ToString();
        D = valDelay.value*100;
    }


    public void ActiveAll()
    {
        foreach(GameObject buttons in Buttons)
        {
            buttons.transform.GetChild(0).gameObject.SetActive(true);
        }

    }
    public void PassiveAll()
    {
        foreach (GameObject buttons in Buttons)
        {
            buttons.transform.GetChild(0).gameObject.SetActive(false);
        }

    }








    List<int> index = new List<int>();
    public void ValUpdate()
    {
        index.Clear();

        for (int i = 0; i < Buttons.Length; i++)
            if (Buttons[i].transform.GetChild(0).gameObject.activeSelf == true)
                index.Add(i);

        if (index.Count < 1) return;

        for (int i = index[0]; i <= index[index.Count - 1]; i++)
        {
            Buttons[i].transform.GetChild(0).gameObject.SetActive(true);
            Buttons[i].transform.GetChild(0).GetComponent<Image>().color = new Color(R / 100, G / 100, B / 100);
        }

        Debug.Log("Red: " + R + " Blue: " + B + " Green:" + G + " DelayTime:" + D + " firstIndex: " + index[0] + " lastIndex: " + index[index.Count - 1]);

        WritetoDB((int)R, (int)B, (int)G, (int)D, index[0], index[index.Count - 1]);

    }

    private void WritetoDB(int r, int g, int b, int delayTime, int indexFirst, int indexLast)
    {

        Neopixel neopixel = new Neopixel(r, g, b, delayTime, indexFirst, indexLast);

        string json = JsonUtility.ToJson(neopixel);

        MyDBreference.Child("Neo").SetRawJsonValueAsync(json);
    }

}
