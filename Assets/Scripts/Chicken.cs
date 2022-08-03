using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : BaseCreature
{
    private void Awake()
    {
        WalkSpeed = 1.0f;
        RunSpeed = 2.0f;
    }
}
