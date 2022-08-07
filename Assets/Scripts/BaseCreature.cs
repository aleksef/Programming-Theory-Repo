using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreature : MonoBehaviour
{
    private Rigidbody m_creatureRb;
    private Animator m_creatureAnimator;
    private GameManager gameManager;

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

    [SerializeField] GameObject m_target;
    public virtual GameObject Target
    {
        get { return m_target; }
        set { m_target = value; }
    }

    [SerializeField] List<string> m_edibles;
    public virtual List<string> Edibles
    {
        get { return m_edibles; }
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        m_creatureRb = gameObject.GetComponent<Rigidbody>();
        m_creatureAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        if (m_target == null) 
        {
            m_target = null;
            Idle();
        }
    }

    private void Move()
    {
        if (currentSpeed != 0 && m_target != null)
        {
            if (Vector3.Distance(transform.position, m_target.transform.position) > 0.1f)
            {
                LookAtTarget();
                m_creatureRb.velocity = transform.rotation * Vector3.forward * currentSpeed;
            }
            else
            {
                Idle();
            }
        }
    }

    private void LookAtTarget()
    {
        Vector3 targetPostition = new(m_target.transform.position.x,
                                      transform.position.y,
                                      m_target.transform.position.z);
        transform.LookAt(targetPostition);
    }

    public void Idle()
    {
        currentSpeed = 0.0f;
        m_creatureRb.velocity = Vector3.zero;
        m_creatureAnimator.SetFloat("Speed_f", 0.0f);
    }

    public void Run()
    {
        currentSpeed = m_runSpeed;
        m_creatureAnimator.SetFloat("Speed_f", 0.6f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Edibles.Contains(other.tag)) 
        {
            Destroy(other.gameObject);
            Idle();
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
            Destroy(gameObject);
    }
}
