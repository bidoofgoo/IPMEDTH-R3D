using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MetingSelectorArm : ADropdownUpdate
{
    private Vector3[] positions = { new Vector3(-2.7f, 0, 0), new Vector3(-1.6f, -1.75f, 0)};
    private Vector3[] rotations = { new Vector3(0, 180, 0), new Vector3(-180, -75, 90) };

    public override void dropdownUpdate(int meting)
    {
        int newIndex = (int)Math.Floor((double)(meting / 2));
        this.transform.position = positions[newIndex];
        this.transform.rotation = Quaternion.Euler(rotations[newIndex]);
        
    }

    public override void onDropdownChange(int meting)
    {
        
    }
}
