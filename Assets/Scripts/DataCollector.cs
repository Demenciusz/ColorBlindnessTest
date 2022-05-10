using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ValuesHolder.timeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ValuesHolder.timeCounter += Time.deltaTime;
    }
}
