using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveButton : MonoBehaviour
{

    public bool activie;
    public Text textt;
    public Material newMat;
    public GameObject save1;
    public GameObject save2;

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
            ChangeColor();
            textt.text = "";
            save1.SetActive(false);
            save2.SetActive(true);
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

    private int HexToDec(string myText)
    {
        int dec = System.Convert.ToInt32(myText, 16);
        return dec;
    }
    private float NormalizationValue(string myText)
    {
        return HexToDec(myText) / 255f;
    }
    private Color GetColorFromString(string myChangingText)
    {
        float red = NormalizationValue(myChangingText.Substring(0, 2));
        float green = NormalizationValue(myChangingText.Substring(2, 2));
        float blue = NormalizationValue(myChangingText.Substring(4, 2));
        return new Color(red, green, blue);
    }
    private void ChangeColor()
    {
        newMat.color = GetColorFromString(textt.text);
    }
}
