using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onSpaceBar : MonoBehaviour
{
    public GameObject Timer; //make ref. in inspector window
    public GameObject Camera; //make ref. in inspector window
    public GameObject Text; //make ref. in inspector window
    public GameObject mainInputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Will only act wehn the user is not focused on the input field
        if ((mainInputField == null || mainInputField.GetComponent<InputField>().isFocused == false) && Input.GetKeyDown(KeyCode.Space))
        {
            Timer.GetComponent<Timer>().timerButton();
            Camera.GetComponent<StartTimer>().playSound();
            Text.GetComponent<startStopTimer>().OnClick();
        }
    }
}
