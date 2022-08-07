using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckForFood();
        StartCoroutine(FoodSearchCycle());
    }

    public void CheckForFood()
    {
        foreach (BaseCreature creature in FindObjectsOfType<BaseCreature>()) 
        {
            foreach (BaseFood food in FindObjectsOfType<BaseFood>())
            {
                if (creature.Edibles.Contains(food.tag)) 
                {
                    creature.Target = food.gameObject;
                    creature.Run();
                }
            }
        }
    }

    private IEnumerator FoodSearchCycle()
    {
        yield return new WaitForSeconds(3);
        CheckForFood();
        StartCoroutine(FoodSearchCycle());
    }
}
