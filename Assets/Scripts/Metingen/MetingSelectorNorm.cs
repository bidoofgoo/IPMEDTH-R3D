using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorNorm : ADropdownUpdate
{
    public override void dropdownUpdate(int meting)
    {
        
    }

    public override void onDropdownChange(int meting)
    {
        this.GetComponent<Text>().text = "Norm: " + Metingen.normen[meting] + "°";
    }
}
