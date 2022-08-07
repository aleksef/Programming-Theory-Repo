using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFood : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
            Destroy(gameObject);
    }
}
