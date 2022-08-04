using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject pointer;
    [SerializeField] GameObject mainCamera;
    private Rigidbody mainCameraRb;

    private void Start()
    {
        mainCameraRb = mainCamera.GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        MoveCamera();
    }

    void MoveCamera() 
    {
        mainCameraRb.velocity = new Vector3(
            Input.GetAxis("Horizontal"),
            mainCameraRb.velocity.y,
            Input.GetAxis("Vertical")).normalized * 10;
    }
}
