using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//https://youtu.be/sU_Y2g1Nidk I used this video tutorial. Instead of writing player, I wrote x, y and z, as referencing to the location of the phone, which is important to this assignment.

public class CSVScript : MonoBehaviour
{
    string filename = "";

    [System.Serializable]

    public class Cube
    {
        public string name;
        public int x;
        public int y;
        public int z;
    }

    [System.Serializable]

    public class DataList
    {
        public Cube[] cube;
    }

    public DataList myDataList = new DataList();

      void Start()
    {
        filename = Application.dataPath + "/test.csv";  
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
        {
            return;
        }
        WriteCSV();
    }

    public void WriteCSV()
    {
        if(myDataList.cube.Length > 0)
        {
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("name, x, y, z");
            tw.Close();

            tw = new StreamWriter(filename, true);

            for(int i = 0; i < myDataList.cube.Length; i++)
            {
                tw.WriteLine(myDataList.cube[i].name + "," + myDataList.cube[i].x + "," + myDataList.cube[i].y + "," + myDataList.cube[i].z);
            }

            tw.Close();
        }
    }

}
