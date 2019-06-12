using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Communicationmanager : MonoBehaviour
{
    private static SerialPort stream;
    public static string data;
    
    void Start()
    {
        stream = new SerialPort("COM6", 9600);
        stream.ReadTimeout = 50;
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        data = readFromHardware();
        Metingen.updateMeting(data);
    }

    public string readFromHardware()
    {
        try{
            return stream.ReadLine();
        }
        catch
        {
            return data;
        }
        
    }

}
