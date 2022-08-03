using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : BaseCreature
{
    private void Awake()
    {
        WalkSpeed = 3.0f;
        RunSpeed = 7.0f;
    }
}
