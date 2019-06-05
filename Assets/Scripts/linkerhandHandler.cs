using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinkerhandHandler : MonoBehaviour
{
    public void SetText(string text)
    {
        Text txt = this.GetComponentInChildren<Text>();
        txt.text = text;
    }
}
