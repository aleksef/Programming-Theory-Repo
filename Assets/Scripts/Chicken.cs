using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : BaseCreature
{
    private void Awake()
    {
        // ENCAPSULATION
        WalkSpeed = 1.0f;
        RunSpeed = 2.0f;
    }
}
