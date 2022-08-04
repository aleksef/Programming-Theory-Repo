using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BaseCreature[] creatures;
    [SerializeField] GameObject wine;
    // Start is called before the first frame update
    void Start()
    {
        /*
        creatures = FindObjectsOfType<BaseCreature>();
        foreach (BaseCreature creature in creatures) 
        {
            creature.Idle();
        }
        */
        BaseCreature human = FindObjectOfType<Human>();
        human.Target = wine;
        human.Walk();
    }

    private void Update()
    {

    }
}
