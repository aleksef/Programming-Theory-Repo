using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : BaseCreature
{
    private void Awake()
    {
        WalkSpeed = 2.5f;
        RunSpeed = 4.0f;
    }
}
