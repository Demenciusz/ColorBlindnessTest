using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerTrackFinder : MonoBehaviour
{
    public float x, z;
    public GameObject player;
    public string positionToSave, xString, zString;
    private void Start()
    {
        InvokeRepeating("SavePosition", 0f, 1f);
    }
    public void SavePosition()
    {
        x = player.transform.position.x;
        z = player.transform.position.z;
        x = (float)Decimal.Round((decimal)x, 2);
        z = (float)Decimal.Round((decimal)z, 2);
        xString = x.ToString();
        zString = z.ToString();
        ValuesHolder.playerPositionX.Add(xString);
        ValuesHolder.playerPositionZ.Add(zString);
        Debug.Log(xString + " " + zString);


    }
}
