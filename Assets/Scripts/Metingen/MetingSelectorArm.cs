using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MetingSelectorArm : ADropdownUpdate
{
    // Deze variabelen slaan de posities en rotaties van de hand op bij bepaalde geselecteerde bewegingen.
    private Vector3[] positionsL = { new Vector3(-2.7f, 0, 0), new Vector3(-1.6f, -1.75f, 0)};
    private Vector3[] rotationsL = { new Vector3(0, 180, 0), new Vector3(-180, -75, 90) };
    private Vector3[] positionsR = { new Vector3(0.5f, 0, 0), new Vector3(-1.6f, -1.75f, 0) };
    private Vector3[] rotationsR = { new Vector3(-180, 180, 180), new Vector3(-180, -75, 90) };

    /*
     * Update die rekening houdt met de huidige meting.
     * Zet de visualisatie van de hand in de juiste positie.
    */
    public override void dropdownUpdate(int meting)
    {
        int newIndex = (int)Math.Floor((double)(meting / 2));
        if (HandSelector.handSelectedLinks)
        {
            this.transform.position = positionsL[newIndex];
            this.transform.rotation = Quaternion.Euler(rotationsL[newIndex]);
            this.transform.localScale = new Vector3(2, 2, -2);
        }
        else
        {
            this.transform.position = positionsR[newIndex];
            this.transform.rotation = Quaternion.Euler(rotationsR[newIndex]);

            this.transform.localScale = new Vector3(2, 2, 2);
        }
    }

    public override void onDropdownChange(int meting){}
}
