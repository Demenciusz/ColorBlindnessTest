using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVDataMenager : MonoBehaviour
{
    public string fileName = "";

    [System.Serializable]
    public class DataToSave
    {
        public string time = ValuesHolder.timeCounter.ToString();
        public string type = ValuesHolder.whatType.ToString();
        public string track = ValuesHolder.lottery.ToString();
        public string position = ValuesHolder.lottery.ToString();
        public string testDate = System.DateTime.Now.ToString();
    }

    [System.Serializable]
    public class DataList
    {
        public DataToSave dataToSave;
    }
    public DataToSave myData = new DataToSave();
    private void Start()
    {
        fileName = Application.dataPath + "/testy.csv";
    }

    public void SaveCSV()
    {
        if(System.IO.File.Exists("testy.csv"))
        {
            TextWriter tw = new StreamWriter(fileName, true);
             tw.WriteLine(myData.time + "," + myData.type + "," + myData.track + "," +
                 myData.position + "," + myData.testDate);
             tw.Close();
            Debug.Log("Dziala");
        }else
        {
            TextWriter tw = new StreamWriter(fileName, false);
            tw.WriteLine("Czas, Typ, Ścieżka, Pozycja, Data Testu");
            tw.Close();

            tw = new StreamWriter(fileName, true);
            tw.WriteLine(myData.time + "," + myData.type + "," + myData.track + "," +
                myData.position + "," + myData.testDate);
            tw.Close();
            Debug.Log("Dziala2");
        }
    }
}
