using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input
        transform.Translate(speed * Time.deltaTime * Vector3.forward * forwardInput);
        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
    }
}
