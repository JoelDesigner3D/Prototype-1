using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // beaviours
    private float speed = 18.0f;
    private float turnSpeed = 25.0f;
    private float jumpSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    private float jumpInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame, cool
    void Update()
    {
        // Keys management
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        // Translate the vehicle 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        // Jump the vehicle
        transform.Translate(Vector3.up * Time.deltaTime * jumpInput * jumpSpeed);
       
    }
}
