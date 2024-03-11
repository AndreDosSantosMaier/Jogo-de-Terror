using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSense = 100f;
    public Transform player;
    float xRotation = 0f;
    public Camera mCamera;
 

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mCamera = Camera.main;
    }

    // 
    void Update()
    {
        look();
    }
    void look()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);

    }

}
