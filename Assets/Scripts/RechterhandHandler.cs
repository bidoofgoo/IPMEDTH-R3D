using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RechterhandHandler : MonoBehaviour
{


    public void SetText(string text)
    {
        Text txt = this.GetComponentInChildren<Text>();
        txt.color = Color.black;
        txt.text = "Rechterhand";
    }

}
