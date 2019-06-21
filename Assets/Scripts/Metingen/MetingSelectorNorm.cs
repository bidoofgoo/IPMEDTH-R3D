using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorNorm : ADropdownUpdate
{
    public override void dropdownUpdate(int meting)
    {
        
    }

    // Weergeeft de norm van de huidige oefening.
    public override void onDropdownChange(int meting)
    {
        //Norm tonen aan de hand van de dropdownchange
        this.GetComponent<Text>().text = "Norm: " + Metingen.normen[meting] + "°";
    }
}
