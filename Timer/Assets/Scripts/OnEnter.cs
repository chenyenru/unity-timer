using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnEnter : MonoBehaviour
{
    public InputField mainInputField;
    // Update is called once per frame
    void Update()
    {
        if (mainInputField.GetComponent<InputField>().isFocused && Input.GetKeyDown(KeyCode.Return)){
            mainInputField.DeactivateInputField();
        }
    }
}
