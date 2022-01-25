using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onSpaceBar : MonoBehaviour
{
    public GameObject Timer; //make ref. in inspector window
    public GameObject Camera; //make ref. in inspector window
    public GameObject Text; //make ref. in inspector window
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Timer.GetComponent<Timer>().timerButton();
            Camera.GetComponent<StartTimer>().playSound();
            Text.GetComponent<startStopTimer>().OnClick();
            
        }
    }
}
