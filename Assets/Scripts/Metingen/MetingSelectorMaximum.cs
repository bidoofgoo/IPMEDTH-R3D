using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorMaximum : ADropdownUpdate
{
    // Kijk of het gaat om de max display van de linker of rechterhand
    public bool links = true;
    // De huidige max
    int max = 0;

    // Zodra er een andere oefening wordt geselecteerd, zet de maximum links en rechts terug naar 0.
    public override void onDropdownChange(int meting)
    {
        max = 0;
        updateText();
    }

    // Als de huidige meting dit getal is, kijk dan of het groter is dan het maximum.
    // In dat geval is huidig nu het nieuwe maximum.
    public void setHuidig(int huidig)
    {
        if(huidig > max)
        {
            max = huidig;
            updateText();
        }
    }

    // Update de tekst naar het huidige maximum.
    private void updateText()
    {
        if (links)
        {
            GetComponent<Text>().text = "Maximum links: " + max + "°";
        }
        else
        {
            GetComponent<Text>().text = "Maximum rechts: " + max + "°";
        }

    }

    public override void dropdownUpdate(int meting) { }
}
