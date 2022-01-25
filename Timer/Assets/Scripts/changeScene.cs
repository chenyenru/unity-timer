using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    bool firstButtonPressed = true;
    bool reset = false;
    float timeOfFirstButton;

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift))&&(SceneManager.GetActiveScene().name == "TwentyFive"))
        {
            Debug.Log("Left Shift key is being pressed");
            SceneManager.LoadScene("Five");
            Debug.Log("Scene Loaded");
        }
        else if ((Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift))&&(SceneManager.GetActiveScene().name == "Ten"))
        {
            Debug.Log("Left Shift key is being pressed");
            SceneManager.LoadScene("TwentyFive");
            Debug.Log("Scene Loaded");
        }
        else if ((Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift))&&(SceneManager.GetActiveScene().name == "Five"))
        {
            Debug.Log("Left Shift key is being pressed");
            SceneManager.LoadScene("Ten");
            Debug.Log("Scene Loaded");
        }


        if (Input.GetKeyDown(KeyCode.Slash))
        {
            if (SceneManager.GetActiveScene().name == "Five" | SceneManager.GetActiveScene().name == "Ten")
            {
                Debug.Log("Slash key is being pressed");
                SceneManager.LoadScene("TwentyFive");
                Debug.Log("Scene Loaded");
            } 
            else if (SceneManager.GetActiveScene().name == "TwentyFive") 
            {
                Debug.Log("Slash key is being pressed");
                SceneManager.LoadScene("Five");
                Debug.Log("Scene Loaded");
            }
        }




        // if((Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift)) && firstButtonPressed) {
        //      if(Time.time - timeOfFirstButton < 0.8f) {
        //          Debug.Log("DoubleClicked");
        //      } else {
        //          Debug.Log("Too late");
        //      }
 
        //      reset = true;
        //  }
 
        //  if((Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift)) && !firstButtonPressed) {
        //      firstButtonPressed = true;
        //      timeOfFirstButton = Time.time;
        //  }
 
        //  if(reset) {
        //      firstButtonPressed = false;
        //      reset = false;
        //  }
    }
    
}
