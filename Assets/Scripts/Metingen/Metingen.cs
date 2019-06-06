using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metingen
{
    public static Vector3 huidigeMeting;
    public static float[] normen = { 85, 85, 45, 15 };

    public static void updateMeting(string serialData)
    {
        // Maak de waardes uit de uitgelezen data schoon.
        string[] waardes = Communicationmanager.data.Replace(", ", ";").Replace('.', ',').Split(';');

        if(waardes.Length == 3)
            huidigeMeting = new Vector3(float.Parse(waardes[0]), float.Parse(waardes[2]) - 180, float.Parse(waardes[1]));
        
        Debug.Log(huidigeMeting);
    }
}
