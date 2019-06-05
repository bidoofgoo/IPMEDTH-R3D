using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ChangeDropdown : MonoBehaviour
{
    public Dropdown myDropdown;

    // Update is called once per frame
    void Update()
    {
        DropdownUpdater.updateToMeting(myDropdown.value);
    }
}
