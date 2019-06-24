using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Communicationmanager : MonoBehaviour
{
    private SerialPort stream;
    public static string data = "0,0,0";

    public int currentPortID = 0;
    private float timer = 0;
    private float wrongCount = 0;
    
    // Start de communicatie met de bluetooth op de com6 port
    void Start()
    {
        openSerial();   
    }

    // Update is called once per frame
    void Update()
    {
        // Haal eens per frame de data uit de hardware op
        data = readFromHardware();
        if (serialDataValidator(data))
        {
            wrongCount = 0;
            Metingen.updateMeting(data);
        }
        else {
            tryNextComPort();
        }

        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    /*
     * Return de huidig gelezen data, mits dat mogelijk is. return anders de oude data.
    */
    public string readFromHardware()
    {
        try{
            return stream.ReadLine();
        }
        catch(Exception exceptio)
        {
            Debug.Log(exceptio);
            tryNextComPort();
            return data;
        }
    }

    // Functie die de binnengekomen data valideerd en anders naar de volgende com port gaat.
    public static bool serialDataValidator(string data)
    {
        // Kijk of de data bestaat.
        if(data == null)
        {
            return false;
        }

        // Maak de waardes uit de uitgelezen data schoon.
        string[] waardes = data.Replace(", ", ";").Replace('.', ',').Split(';');

        //foutafhandeling als de replace/split niet goed is uitgevoerd
        if (waardes.Length == 3)
        {
            return true;
        } 
        return false;
    }

    // Functie die ervoor zorgt dat er een andere com-port wordt geselecteerd.
    private void tryNextComPort()
    {
        // Mag pas een andere port selecteren als het 10 keer fout is gegaan eigenlijk. 
        // (eerste reads uit de seriele verbindign gaan meestal verkeerd)
        if(wrongCount > 10)
        {
            wrongCount = 0;
            if (stream.IsOpen)
            {
                stream.Close();
            }
            if (timer <= 0)
            {
                if (currentPortID < SerialPort.GetPortNames().Length - 1)
                {
                    currentPortID++;
                }
                else
                {
                    currentPortID = 0;
                }
                openSerial();
            }
        }
        else
        {
            wrongCount++;
        }
    }

    // Functie die serial opent
    private void openSerial()
    {
        timer = 1;
        stream = new SerialPort("\\.\\" + SerialPort.GetPortNames()[currentPortID], 9600);
        Debug.Log("Opening: " + "\\.\\" + SerialPort.GetPortNames()[currentPortID]);
        stream.ReadTimeout = 50;
        stream.Open();
    }

}
