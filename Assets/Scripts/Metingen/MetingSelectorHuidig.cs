using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorHuidig : ADropdownUpdate
{
    float baseY = 0;

    public override void dropdownUpdate(int meting)
    {
        Text text = this.GetComponent<Text>();
        int newmeting = 0;
        

        switch (meting)
        {
            case 0:
                newmeting = (int)Mathf.Clamp(-Metingen.huidigeMeting.x, 0, 500);
                break;
            case 1:
                newmeting = (int)Mathf.Clamp(Metingen.huidigeMeting.x, 0, 500);
                break;
            case 2:
                newmeting = (int)Mathf.Clamp(Metingen.huidigeMeting.y - baseY, 0, 500);
                break;
            case 3:
                break;
            default:
                break;
        }

        text.text = "Huidige Meting: " + newmeting + "°";
    }

    public override void onDropdownChange(int meting)
    {
        baseY = Metingen.huidigeMeting.y;
    }
}
