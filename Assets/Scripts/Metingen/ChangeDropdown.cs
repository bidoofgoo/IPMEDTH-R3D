using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

// Klasse die kijkt of de dropdown value veranderd is.
public class ChangeDropdown : MonoBehaviour
{
    // Dropdown menu waar we uit lezen wat de huidige meting is
    public Dropdown myDropdown;

    // Update is called once per frame
    void Update()
    {
        // Pas iedere frame de meting aan.
        DropdownUpdater.updateToMeting(myDropdown.value);
    }
}
