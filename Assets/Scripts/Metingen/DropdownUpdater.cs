using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownUpdater
{
    /*
     * Dit is een int die opslaat wat de laatst bekende dropdown was. Zo kan er gedetecteerd worden of er deze
     * frame wordt overgegaan naar een andere beweging
    */ 
    public static int lastDropdown = 100;

    /*
     * Lijst met de verschillende soorten metingen. Per meting staan alle updates die gedaan moeten worden.
     */
    private static List<ADropdownUpdate> updates = new List<ADropdownUpdate>();

    /*
     * Voegt een DropdownUpdate toe aan de lijst met updates
    */
    public static void addUpdate(ADropdownUpdate update)
    {
        updates.Add(update);
    }

    /*
     * Voert alle updates in de lijst met updates uit zodra de waarde wordt veranderd
    */
    public static void updateToMeting(int meting)
    {
        // Alleen als de dropdown is aangepast
        if(meting != lastDropdown)

        {
            foreach (ADropdownUpdate update in updates)
            {
                update.onDropdownChange(meting);
                Debug.Log(((meting == 0) ? "palmair" : (meting == 1) ? "dorsaal" : (meting == 2) ? "ulnair" : "radiaal") + " geselecteerd");
            }
            lastDropdown = meting;
        }
      
        // Voor iedere update
        foreach (ADropdownUpdate update in updates) {
            update.dropdownUpdate(meting);
        }
    }
}
