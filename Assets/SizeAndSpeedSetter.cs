using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeAndSpeedSetter : MonoBehaviour
{
    public Text theSize;
    public Text theSpeed;
    int timeLeft;
    public Text countdown;
    void Start()
    {
        StartCoroutine("Timer");
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
        theSize.text = "Size: " + ToggleAndSliderAndDropDown.size;
        theSpeed.text = "Speed: " + ToggleAndSliderAndDropDown.speed;
        countdown.text = ("" + timeLeft);

    }
    IEnumerator Timer()
    {
        timeLeft = ToggleAndSliderAndDropDown.time;
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}

