using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSelector : MonoBehaviour
{
    // Variabele die bepaald of dit om een linker of rechter hand gaat.
    public bool links;
    // Variabele die refereerd naar andere knop, zodat die wordt gedeselecteerd zodra deze wordt geselecteerd
    public HandSelector otherHandButton;
    // Huidig geslecteerde hand
    public static bool handSelectedLinks = true;

    private void Start()
    {
        // Standaard geselecteerde hand is links, bij het opstarten emuleer een click event mits dit links is
        if (this.links)
        {
            onClick();
        }
    }

    // Zet de kleur van de tekst van het gameobject waar deze script op staat geladen.
    public void setColor(Color color)
    {
        // Get text van de button, en pas de kleur hiervan aan.
        Text txt = this.GetComponentInChildren<Text>();
        txt.color = color;
    }

    // Functie die wordt aangeroepen zodra de andere hand wordt aangeroepen.
    public void onClick()
    {
        // Switcht tussen de twee kleuren zodat er gezien kan worden welke button geselecteerd is.
        setColor(Color.white);
        handSelectedLinks = links;
        otherHandButton.setColor(new Color(1, 1, 1,0.75F));
    }

}
