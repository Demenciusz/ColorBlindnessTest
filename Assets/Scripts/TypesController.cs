using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypesController : MonoBehaviour
{
    public bool activie;
    public int valueof;
    // Start is called before the first frame update
    void Start()
    {
        activie = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(activie == true && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Joystick1Button0)))
        {
            ValuesHolder.whatType = valueof;
            ValuesHolder.lottery = Random.Range(0, 39);
            ValuesHolder.randomValue = Random.Range(0, 2);
            Debug.Log(ValuesHolder.lottery);
            Debug.Log(ValuesHolder.randomValue);
            
            SceneManager.LoadScene(1);
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
