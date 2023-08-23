using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float turningSpeed = 75;

    private float horizontalMovement;
    private float verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed* Time.deltaTime * verticalMovement);
        transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime * horizontalMovement);
    }
}
