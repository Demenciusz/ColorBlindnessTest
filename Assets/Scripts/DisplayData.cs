using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{
    public Text displayTimeValue;
    public Text displayPointValue;
    public Text displayTrackValue;
    

    void Start()
    {
        
        displayTimeValue.text = ValuesHolder.timeCounter.ToString();
        displayTrackValue.text = ValuesHolder.lottery.ToString();
        displayPointValue.text = ValuesHolder.randomValue.ToString();
    }

    
}
