using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorHuidig : ADropdownUpdate
{
    float baseY = 0;

    public static BewegendeHand hand;

    public override void dropdownUpdate(int meting)
    {
        Text text = this.GetComponent<Text>();
        float newmeting = 0;
        

        switch (meting)
        {
            case 0:
                newmeting = Mathf.Clamp(-Metingen.huidigeMeting.x, 0, 500);
                hand.transform.rotation = Quaternion.Euler(new Vector3(newmeting + 90, 90, 0));
                break;
            case 1:
                newmeting = Mathf.Clamp(Metingen.huidigeMeting.x, 0, 500);
                hand.transform.rotation = Quaternion.Euler(new Vector3(-newmeting + 90, 90, 0));
                break;
            case 2:
                newmeting = Mathf.Clamp(Metingen.huidigeMeting.y - baseY, 0, 500);
                hand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case 3:
                break;
            default:
                break;
        }

        text.text = "Huidige Meting: " + (int)newmeting + "°";
    }

    public override void onDropdownChange(int meting)
    {
        baseY = Metingen.huidigeMeting.y;
    }
}
