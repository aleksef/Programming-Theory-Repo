using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreature : MonoBehaviour
{
    private Rigidbody baseCreatureRb;
    private Animator animator;
    private float currentSpeed = 0.0f;

    private float m_walkSpeed;
    public virtual float WalkSpeed 
    {
        get { return m_walkSpeed; }
        protected set { m_walkSpeed = value; }
    }
    private float m_runSpeed;
    public virtual float RunSpeed
    {
        get { return m_runSpeed; }
        protected set { m_runSpeed = value; }
    }


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
        baseCreatureRb.velocity = transform.rotation * Vector3.forward * currentSpeed;
    }

    private void Idle()
    {
        currentSpeed = 0.0f;
        animator.SetFloat("Speed_f", 0.0f);
    }

    private void Walk() 
    {
        currentSpeed = m_walkSpeed;
        animator.SetFloat("Speed_f", 0.26f);
    }

    private void Run()
    {
        currentSpeed = m_runSpeed;
        animator.SetFloat("Speed_f", 0.6f);
    }
}
