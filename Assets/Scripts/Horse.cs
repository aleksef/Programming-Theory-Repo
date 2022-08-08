using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Horse : BaseCreature
{
    private void Awake()
    {
        // ENCAPSULATION
        WalkSpeed = 3.5f;
        RunSpeed = 10.0f;
    }
}
