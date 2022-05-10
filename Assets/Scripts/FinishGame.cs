using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.Joystick1Button4)) || ValuesHolder.timeCounter > 300)
        {
            ValuesHolder.ended = false;
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Tak");
            ValuesHolder.ended = true;
            SceneManager.LoadScene(2);
        }
    }

}
