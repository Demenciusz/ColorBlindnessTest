using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SaveDataButton : MonoBehaviour
{
    public string fileName = "";
    public string fileTrack = "";
    public string dateString = "";

    string time = ValuesHolder.timeCounter.ToString();
    string type = ValuesHolder.whatType.ToString();
    string track = ValuesHolder.lottery.ToString();
    string position = ValuesHolder.randomValue.ToString();
    string verdict = ValuesHolder.ended.ToString();
    string testDate = System.DateTime.Now.ToString();

    public bool activie;

    private void Start()
    {

        fileName = Application.persistentDataPath + "/testy.csv";
        dateString = System.DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss");
        fileTrack = Application.persistentDataPath + "/" + dateString + "plik.csv";
        print(Application.persistentDataPath);
        Debug.Log(Application.persistentDataPath);
    }
    void Update()
    {
        if (activie == true && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Joystick1Button0)))
        {
            SaveCSV();
            SceneManager.LoadScene(0);
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
    public void SaveCSV()
    {
        if (File.Exists(fileName))
        {
            Debug.Log("Z1");
            TextWriter twr = new StreamWriter(fileName, true);
            twr.WriteLine(time + " ;" + type + " ;" + track + " ;" +
                position + " ;" + testDate + ";" + verdict);
            twr.Close();

        }
        else
        {
            Debug.Log("Z2");
            TextWriter twr = new StreamWriter(fileName, false);
            twr.WriteLine("Czas" + ";" + "Typ" + ";" + "Sciezka" + ";" + "Pozycja" + ";" +
                "Data Testu" + ";" + "Czy zaliczony");
            twr.Close();

            twr = new StreamWriter(fileName, true);
            twr.WriteLine(time + ";" + type + ";" + track + ";" +
                position + ";" + testDate + ";" + verdict);
            twr.Close();
        }
        
            Debug.Log("Z2");
            TextWriter tw = new StreamWriter(fileTrack, true);
            tw.WriteLine("Zapisana trasa");
            tw.Close();

            tw = new StreamWriter(fileTrack, true);
            for (int i = 0; i < ValuesHolder.playerPositionX.Count; i++)
            {
                tw.WriteLine("x:" + ValuesHolder.playerPositionX[i] + ";" + "z:" + ValuesHolder.playerPositionZ[i]);
                
            }
            tw.Close();
            ValuesHolder.playerPositionX.Clear();
            ValuesHolder.playerPositionZ.Clear();
        


    }
}
