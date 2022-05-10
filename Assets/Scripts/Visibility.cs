using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visibility : MonoBehaviour
{

    public Text textField;
    public GameObject saveButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VisibilityObject();
    }
    public void VisibilityObject()
    {
        if (textField.text.Length == 6)
        {
            saveButton.SetActive(true);
        }
        else
        {
            saveButton.SetActive(false);
        }
    }
}
