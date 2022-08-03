using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreature : MonoBehaviour
{
    private Rigidbody baseCreatureRb;
    private Animator animator;
    private float currentSpeed = 0.0f;
    private float walkSpeed = 3.0f;
    private float runSpeed = 5.0f;

    void Awake()
    {
        baseCreatureRb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
        Idle();
    }

    void Update()
    {
        if (currentSpeed != 0) 
        {
            Move();
        }
    }

    private void Move()
    {
        baseCreatureRb.velocity = Vector3.forward * currentSpeed;
    }

    private void Idle()
    {
        currentSpeed = 0.0f;
        animator.SetFloat("Speed_f", 0.0f);
    }

    private void Walk() 
    {
        currentSpeed = walkSpeed;
        animator.SetFloat("Speed_f", 0.26f);
    }

    private void Run()
    {
        currentSpeed = runSpeed;
        animator.SetFloat("Speed_f", 0.6f);
    }
}
