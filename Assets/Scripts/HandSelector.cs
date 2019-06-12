using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSelector : MonoBehaviour
{
    public bool links;
    public HandSelector otherHandButton;
    public static bool handSelectedLinks;

    public void setColor(Color color)
    {
        Text txt = this.GetComponentInChildren<Text>();
        txt.color = color;
    }
    public void onClick()
    {
        setColor(Color.white);
        handSelectedLinks = links;
        otherHandButton.setColor(new Color(1, 1, 1,0.75F));
    }

}
