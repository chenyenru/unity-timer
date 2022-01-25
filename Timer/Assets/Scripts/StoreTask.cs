using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreTask  : MonoBehaviour
{
    public string theTask;
    public GameObject inputField;
    public GameObject textDisplay;

    public void storeName()
    {
        theTask = inputField.GetComponent<Text>().text;
        //textDisplay.GetComponent<Text>().text = "Understood, your plan now is" + theTask;
    }
}