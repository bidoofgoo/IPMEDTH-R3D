using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ADropdownUpdate : MonoBehaviour
{
    abstract public void doTheUpdate(int meting);

    private void Start()
    {
        DropdownUpdater.addUpdate(this);
    }
}
