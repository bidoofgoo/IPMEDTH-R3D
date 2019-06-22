using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegendeHand : MonoBehaviour
{
    // Dit is de hand waar in MetingSelectorHuidig naar wordt gerefereerd.
    private void Start()
    {
        MetingSelectorHuidig.hand = this;
    }
}
