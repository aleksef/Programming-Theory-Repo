using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private Vector3 worldPos;
    Plane plane = new Plane(Vector3.down, 0);

    void Start()
    {
        Cursor.visible = true; // Set hardware cursor visibility
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out float distance))
        {
            worldPos = ray.GetPoint(distance);
        }
        transform.position = new Vector3(worldPos.x, 0.6f, worldPos.z);
    }
}
