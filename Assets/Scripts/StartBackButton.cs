using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBackButton : MonoBehaviour
{
    public bool activie;
    public GameObject menu1;
    public GameObject menu2;
    // Start is called before the first frame update
    void Start()
    {
        activie = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activie == true && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Joystick1Button0)))
        {
            ValuesHolder.timeCounter = 0;
            menu1.SetActive(false);
            menu2.SetActive(true);
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
