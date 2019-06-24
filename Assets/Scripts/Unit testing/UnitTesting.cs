using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Communicationmanager.serialDataValidator(null));
        Debug.Log(Communicationmanager.serialDataValidator("ik ben fout"));
        Debug.Log(Communicationmanager.serialDataValidator("45.45, -45.45, 45.45"));

        max = 0;
        setHuidig(-10);
        Debug.Log(max);

        max = 0;
        setHuidig(10);
        Debug.Log(max);
    }

    public static int max = 0;

    public static void setHuidig(int huidig)
    {
        if (huidig > max)
        {
            max = huidig;
        }
    }

}
