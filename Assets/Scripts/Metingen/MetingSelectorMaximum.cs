using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorMaximum : ADropdownUpdate
{
    public bool links = true;
    int max = 0;

    public override void dropdownUpdate(int meting)
    {
        
    }

    public override void onDropdownChange(int meting)
    {
        max = 0;
        updateText();
    }

    public void setHuidig(int huidig)
    {
        if(huidig > max)
        {
            max = huidig;
            updateText();
        }
    }

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

}
