using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cow : BaseCreature
{
    private void Awake()
    {
        // ENCAPSULATION
        WalkSpeed = 2.5f;
        RunSpeed = 4.0f;
    }

    // POLYMORPHISM
    public override void Greet() 
    {
        Debug.Log($"Moo!");
    }
}
