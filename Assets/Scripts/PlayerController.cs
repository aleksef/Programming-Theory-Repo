using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject pointer;
    [SerializeField] GameObject mainCamera;
    private Rigidbody mainCameraRb;

    [SerializeField] GameObject[] spawnableObjects;
    private GameObject selectedObject;

    private void Start()
    {
        mainCameraRb = mainCamera.GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        MoveCamera();

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            SpawnObject();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            selectedObject = null;
        }
    }

    void MoveCamera() 
    {
        mainCameraRb.velocity = new Vector3(
            Input.GetAxis("Horizontal"),
            mainCameraRb.velocity.y,
            Input.GetAxis("Vertical")).normalized * 10;
    }

    void SpawnObject() 
    {
        if (selectedObject != null) 
        {
            Debug.Log("Spawn!");
            Instantiate(selectedObject, pointer.transform.position, selectedObject.transform.rotation);
        }
    }

    public void SelecObjectToSpawn(int value) 
    {
        selectedObject = spawnableObjects[value];
    }
}
