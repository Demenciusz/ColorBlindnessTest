using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointsAndWaysController : MonoBehaviour
{

    public GameObject[] way = new GameObject[39];
    public GameObject[] start = new GameObject[39];
    public GameObject[] end = new GameObject[39];
    Vector3 newWayPos = new Vector3(0f, 0.01f, 0f);

    public GameObject player;

    public int[] yRotationStart = new int[39];
    public int[] yRotationEnd = new int[39];
    public Vector3[] positionStart = new Vector3[39];
    public Vector3[] positionEnd = new Vector3[39];

    void Start()
    {
        way[ValuesHolder.lottery].transform.position = newWayPos;
        if(ValuesHolder.randomValue == 1)
        {
            player.transform.position = positionStart[ValuesHolder.lottery];
            player.transform.Rotate(0.0f, yRotationStart[ValuesHolder.lottery], 0.0f, Space.World);
            end[ValuesHolder.lottery].SetActive(true);
        }
        else if(ValuesHolder.randomValue == 0)
        {
            player.transform.position = positionEnd[ValuesHolder.lottery];
            player.transform.Rotate(0.0f, yRotationEnd[ValuesHolder.lottery], 0.0f, Space.World);
            start[ValuesHolder.lottery].SetActive(true);
        }    
        
    }
}
