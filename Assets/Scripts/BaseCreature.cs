using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreature : MonoBehaviour
{
    private Rigidbody m_creatureRb;
    public virtual Rigidbody CreatureRb
    {
        get { return m_creatureRb; }
        protected set { m_creatureRb = value; }
    }

    private Animator m_creatureAnimator;
    public virtual Animator CreatureAnimator
    {
        get { return m_creatureAnimator; }
        protected set { m_creatureAnimator = value; }
    }

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

    void Update()
    {
        if (currentSpeed != 0) 
        {
            Move();
        }
    }

    private void Move()
    {
        m_creatureRb.velocity = transform.rotation * Vector3.forward * currentSpeed;
    }

    public void Idle()
    {
        currentSpeed = 0.0f;
        m_creatureAnimator.SetFloat("Speed_f", 0.0f);
    }

    public void Walk() 
    {
        currentSpeed = m_walkSpeed;
        m_creatureAnimator.SetFloat("Speed_f", 0.26f);
    }

    public void Run()
    {
        currentSpeed = m_runSpeed;
        m_creatureAnimator.SetFloat("Speed_f", 0.6f);
    }
}
