using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeDropdown : MonoBehaviour
{
    public Camera cam;
    public Dropdown myDropdown;

    // Update is called once per frame
    void Update()
    {
        switch(myDropdown.value)
        {
            case 0:
                cam.backgroundColor = Color.white;
                break;

            case 1:
                cam.backgroundColor = Color.red;
                break;

            case 2:
                cam.backgroundColor = Color.blue;
                break;

            case 3:
                cam.backgroundColor = Color.green;
                break;

        }
    }
}
