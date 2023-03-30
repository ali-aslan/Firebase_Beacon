using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neopixel : MonoBehaviour
{
    public int Red;
    public int Green;
    public int Blue;
    public int DelayTime;
    public int IndexLast;
    public int IndexFirst;


    public Neopixel(int red,int green,int blue,int delayTime,int indexFirst,int indexLast)
    {
        this.Red = red;
        this.Green = green;
        this.Blue = blue;
        this.DelayTime = delayTime;
        this.IndexFirst = indexFirst;
        this.IndexLast = indexLast;
    }

}
