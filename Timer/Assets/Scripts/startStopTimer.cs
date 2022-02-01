using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startStopTimer : MonoBehaviour
{
    public bool isStart = false;
    public Text buttonText;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (isStart){
            buttonText.text = "Stop";
        } else {
            buttonText.text = "Start";
        }
    }
    
    public void OnClick()
    {
        isStart = !isStart;
    }
}
