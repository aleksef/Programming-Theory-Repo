using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : BaseCreature
{
    private void Awake()
    {
        WalkSpeed = 3.5f;
        RunSpeed = 10.0f;
    }
}
