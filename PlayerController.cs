using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 7.5f;
    private float turnSpeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;


    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal") * forwardInput;
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward(z), right-left(x) with rotation
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(horizontalInput * turnSpeed * Time.deltaTime * Vector3.up);
    }
}
