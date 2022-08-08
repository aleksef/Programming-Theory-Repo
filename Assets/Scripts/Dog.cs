using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : BaseCreature
{
    private void Awake()
    {
        // ENCAPSULATION
        WalkSpeed = 3.0f;
        RunSpeed = 7.0f;
    }

    // POLYMORPHISM
    public override void Greet()
    {
        Debug.Log($"Woof!");
    }
}
