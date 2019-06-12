using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metingen
{
    public static Vector3 huidigeMeting;
    //de normen zijn gekoppeld aan de bewegingen in de dropdown
    public static float[] normen = { 85, 85, 45, 15 };

    public static void updateMeting(string serialData)
    {
        // Maak de waardes uit de uitgelezen data schoon.
        string[] waardes = Communicationmanager.data.Replace(", ", ";").Replace('.', ',').Split(';');

        //foutafhandeling als de replace/split niet goed is uitgevoerd
        if(waardes.Length == 3)
            huidigeMeting = new Vector3(float.Parse(waardes[0]), float.Parse(waardes[2]) - 180, float.Parse(waardes[1]));
        
        Debug.Log(huidigeMeting);
    }
}
