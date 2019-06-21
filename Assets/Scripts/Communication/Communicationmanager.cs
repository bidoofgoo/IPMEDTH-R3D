using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Communicationmanager : MonoBehaviour
{
    private static SerialPort stream;
    public static string data;
    
    // Start de communicatie met de bluetooth op de com6 port
    void Start()
    {
        stream = new SerialPort("COM6", 9600);
        stream.ReadTimeout = 50;
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        // Haal eens per frame de data uit de hardware op
        data = readFromHardware();
        Metingen.updateMeting(data);
    }

    /*
     * Return de huidig gelezen data, mits dat mogelijk is. return anders de oude data.
    */
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
