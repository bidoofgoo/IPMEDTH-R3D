using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metingen
{
    public static Vector3 huidigeMeting;
    //de normen zijn gekoppeld aan de bewegingen in de dropdown
    public static float[] normen = { 85, 85, 45, 15 };


    /*
     *  Deze functie wordt eens per unity update uitgevoerd. Dit zorgt ervoor dat 
    */
    public static void updateMeting(string serialData)
    {
        // Maak de waardes uit de uitgelezen data schoon.
        string[] waardes = Communicationmanager.data.Replace(", ", ";").Replace('.', ',').Split(';');

        //foutafhandeling als de replace/split niet goed is uitgevoerd
        if(waardes.Length == 3)
            // Voert een lerp uit die ervoor zorgt dat de waardes over een halve seconde in mate aangepast worden naar de nieuwe waarden.
            // Dit wordt gedaan om extreme waarden minder extreem te maken.
            // Dit wordt niet gedaan over de y-as, aangezien dit niet mogelijk is. Dit komt omdat de waardes naar voren niet altijd 0 graden zijn.
            huidigeMeting = Vector3.Lerp(
                new Vector3(huidigeMeting.x, -float.Parse(waardes[2]), huidigeMeting.z), 
                new Vector3(float.Parse(waardes[0]), -float.Parse(waardes[2]), float.Parse(waardes[1])), 
                Time.deltaTime * 2);
        
        Debug.Log(huidigeMeting);
    }
}
