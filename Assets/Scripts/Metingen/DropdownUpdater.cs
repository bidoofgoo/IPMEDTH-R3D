using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownUpdater
{
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
        // Voor iedere update
        foreach (ADropdownUpdate update in updates) {
            update.dropdownUpdate(meting);
        }
    }
}
