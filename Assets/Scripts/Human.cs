using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : BaseCreature
{
    private void Awake()
    {
        WalkSpeed = 3.0f;
        RunSpeed = 5.0f;
    }
}
