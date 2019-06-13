using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegendeHand : MonoBehaviour
{
    public static float currentRot = 0;

    private void Start()
    {
        MetingSelectorHuidig.hand = this;
    }
}
