using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue=1500;
    public float settedTime;
    public Text timeText;

    bool timerActive = false;
    public AudioSource timesUpSound;

    float doubleClickTime = .2f, lastClickTime;    

    // Update is called once per frame
    void Update()
    {
        if (timerActive){
            if (timeValue>0)
            {
                timeValue -= Time.deltaTime;
            }
            else if (timeValue==0)
            {
                timesUpSound.Play();
                timeValue = settedTime;
            }
        }
        

        DisplayTime(timeValue);


        if (Input.GetMouseButtonDown(0))
        {
            float timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= doubleClickTime)
                timeValue = settedTime;
            else
                Debug.Log("Normal click");

            lastClickTime = Time.time;
        }


    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void timerButton(){
        timerActive = !timerActive;
    }

    public void Reset()
    {
        
    }


}
 