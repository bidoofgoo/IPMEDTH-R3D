using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetingSelectorHuidig : ADropdownUpdate
{
    float baseY = 0;

    // Referentie naar het hand gameobject
    public static BewegendeHand hand;

    public override void dropdownUpdate(int meting)
    {
        Text text = this.GetComponent<Text>();
        float newmeting = 0;

        switch (meting)
        {
            case 0:
                newmeting = Mathf.Clamp(-Metingen.huidigeMeting.x, 0, 180);
                if(HandSelector.handSelectedLinks)
                    hand.transform.rotation = Quaternion.Euler(new Vector3(newmeting + 90, 90, 0));
                else
                    hand.transform.rotation = Quaternion.Euler(new Vector3(-newmeting - 90, 90, 0));
                break;
            case 1:
                newmeting = Mathf.Clamp(Metingen.huidigeMeting.x, 0, 180);
                if (HandSelector.handSelectedLinks)
                    hand.transform.rotation = Quaternion.Euler(new Vector3(-newmeting + 90, 90, 0));
                else
                    hand.transform.rotation = Quaternion.Euler(new Vector3(newmeting - 90, 90, 0));
                break;
            case 2:
                float shifted = Metingen.huidigeMeting.y - baseY;
                if(shifted > 180) {
                    shifted -= 360;
                }else if(shifted < -180)
                {
                    shifted += 360;
                }
                if (HandSelector.handSelectedLinks)
                {
                    newmeting = -Mathf.Clamp(shifted, -180, 0);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, newmeting));
                }
                else
                {
                    newmeting = Mathf.Clamp(shifted, 0, 180);
                    hand.transform.rotation = Quaternion.Euler(new Vector3(0, 180, newmeting));
                }
                
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
