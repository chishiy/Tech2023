using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform playerCamera;
    private float movementSpeed = 5;
    private float rotationSpeed = 3.5f;

    private float cameraPitch = 0f;
    private float verticalMovement;
    //private bool lockCursor = true;
    

    //private float horizontalMovement;

    void Start()
    {

        /*if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }*/
    }

    void Update()
    {
        MouseLook();
        MouseMovement();
        
    }
    void MouseLook()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        cameraPitch -= mouseDelta.y * rotationSpeed;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * mouseDelta.x * rotationSpeed);
    }

    void MouseMovement()
    {

        verticalMovement = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime * verticalMovement);

        //horizontalMovement = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime * horizontalMovement);
    }

    
}
