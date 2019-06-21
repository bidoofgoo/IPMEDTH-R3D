using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorHuidig : ADropdownUpdate
{
    // Callibratie variabele van de meting op de y as
    float baseY = 0;

    // Referentie naar het hand gameobject
    public static BewegendeHand hand;
    // Referenties naar maximum links object en maximum rechts object
    public MetingSelectorMaximum maxLinks;
    public MetingSelectorMaximum maxRechts;


    /*
     * Update die uitvoerd tijdens een update met de huidige meting als parameter
     * Past de huidige meting aan op het scherm, past de visualisatie toe op de hand en stelt de maximum waardes in.
    */ 
    public override void dropdownUpdate(int meting)
    {
        Text text = this.GetComponent<Text>();
        float newmeting = 0;
        float shifted = 0;

        switch (meting)
        {
            
            case 0:
                newmeting = Mathf.Clamp(-Metingen.huidigeMeting.x, 0, 180);
                if(HandSelector.handSelectedLinks)
                    hand.transform.rotation = Quaternion.Euler(new Vector3(newmeting + 90, 90, 0));
                else
                    hand.transform.rotation = Quaternion.Euler(new Vector3(-newmeting - 90, 90, 0));
                break;
            case 1:
                newmeting = Mathf.Clamp(Metingen.huidigeMeting.x, 0, 180);
                if (HandSelector.handSelectedLinks)
                    hand.transform.rotation = Quaternion.Euler(new Vector3(-newmeting + 90, 90, 0));
                else
                    hand.transform.rotation = Quaternion.Euler(new Vector3(newmeting - 90, 90, 0));
                break;
            case 2:
                shifted = Metingen.huidigeMeting.y - baseY;
                if(shifted > 180) {
                    shifted -= 360;
                }else if(shifted < -180)
                {
                    shifted += 360;
                }
                if (HandSelector.handSelectedLinks)
                {
                    newmeting = -Mathf.Clamp(shifted, -180, 0);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, newmeting));
                }
                else
                {
                    newmeting = Mathf.Clamp(shifted, 0, 180);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 180, newmeting));
                }
                
                break;
            case 3:
                shifted = Metingen.huidigeMeting.y - baseY;
                if (shifted > 180)
                {
                    shifted -= 360;
                }
                else if (shifted < -180)
                {
                    shifted += 360;
                }
                if (HandSelector.handSelectedLinks)
                {
                    newmeting = Mathf.Clamp(shifted, 0, 180);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -newmeting));
                }
                else
                {
                    newmeting = -Mathf.Clamp(shifted, -180, 0);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 180, -newmeting));
                }
                break;
            default:
                break;
        }

        text.text = "Huidige Meting: " + (int)newmeting + "°";
        if (HandSelector.handSelectedLinks)
        {
            maxLinks.setHuidig((int)newmeting);
        }
        else
        {
            maxRechts.setHuidig((int)newmeting);
        }
    }

    // Deze functie roept aan zodra de dropdown veranderd van waarde. (dus als er een andere oefening wordt gesoorteerd)
    public override void onDropdownChange(int meting)
    {
        // Calibreer de y waarde van de handschoen.
        baseY = Metingen.huidigeMeting.y;
    }
}
