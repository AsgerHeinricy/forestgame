using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public bool IsGrounded = false;

    public float mouseSensivity;
    public Transform playerBody;
    float xRotation = 0f;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded == true)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90);


            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);

            
        }
       
        
    }
}