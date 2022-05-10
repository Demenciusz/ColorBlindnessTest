using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExitButton : MonoBehaviour
{
    public bool activie;

    // Update is called once per frame
    void Update()
    {
        if(activie == true && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Joystick1Button0)))
        {
            Application.Quit();
        }
    }
    public void ActivieTrue()
    {
        activie = true;
    }
    public void ActivieFalse()
    {
        activie = false;
    }
}
