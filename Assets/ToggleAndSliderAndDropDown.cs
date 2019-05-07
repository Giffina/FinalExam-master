using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAndSliderAndDropDown : MonoBehaviour
{
    public Toggle toggie;
    public Slider sliddie;
    public Dropdown droppie;

    public static int speed;
    public static int size;
    public static int time;

    static int unlimited = 100000;
    static int med = 60;
    static int big = 120;

    public bool togVal = false;
    
    public void ToggleSelect(bool togVal)
    {

        //sliddie.interactable = false;
        if (togVal == false)
        {
            sliddie.enabled = false;
        }
        else
        {
            sliddie.enabled = true;
        }
    }
    public void Drop()
    {
        switch(droppie.value)
        {
            case 1:
                size = 1;
                speed = 1;
                break;
            case 2:
                size = 2;
                speed = 2;
                break;
            case 3:
                size = 3;
                speed = 3;
                break;
            default:
                size = 1;
                speed = 1;
                break;
        }
    }
    public void Slide()
    {
        switch (droppie.value)
        {
            case 1:
                time = unlimited;
                break;
            case 2:
                time = med;
                break;
            case 3:
                time = big;
                break;
            default:
                time = unlimited;
                break;
        }
    }
}
