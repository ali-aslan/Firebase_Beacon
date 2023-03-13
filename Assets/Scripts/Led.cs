using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Led : MonoBehaviour
{
    bool active = false;
    int a = 0;


    void Start()
    {
        transform.gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);

    }

    public void ButtonClicked()
    {
        active = !active;
        transform.GetChild(0).gameObject.SetActive(active);
        a++; 


        if(a>3)
        transform.GetChild(0).GetComponentInChildren<Image>().color = new Color32(150, 255, 130, 100);


    }
}
