using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackspaceController : MonoBehaviour
{
    public bool activie;
    public Text textt;
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
            textt.text = textt.text.Remove(textt.text.Length - 1, 1);
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
