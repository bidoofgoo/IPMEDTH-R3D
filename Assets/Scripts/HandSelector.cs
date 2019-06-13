using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSelector : MonoBehaviour
{
    //Aanmaken variabele
    public bool links;
    public HandSelector otherHandButton;
    public static bool handSelectedLinks = true;

    private void Start()
    {
        if (this.links)
        {
            onClick();
        }
    }

    public void setColor(Color color)
    {
        //get text van de button
        Text txt = this.GetComponentInChildren<Text>();
        txt.color = color;
    }
    public void onClick()
    {
        //switcht tussen de twee kleuren zodat er gezien kan worden wlke button geselecteerd is
        setColor(Color.white);
        handSelectedLinks = links;
        otherHandButton.setColor(new Color(1, 1, 1,0.75F));
    }

}
