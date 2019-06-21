using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ADropdownUpdate : MonoBehaviour
{
    // Update die iedere update wordt uitgevoerd als het deze klasse extend, met als parameter de huidige meting
    abstract public void dropdownUpdate(int meting);
    // Update die iedere keer wordt uitgevoerd als het deze klasse extend, met als parameter de huidige meting
    abstract public void onDropdownChange(int meting);

    // Voeg deze klasse toe aan een lijst waarmee wordt bijgehouden welke updates gedaan moeten worden.
    private void Start()
    {
        DropdownUpdater.addUpdate(this);
    }
}
