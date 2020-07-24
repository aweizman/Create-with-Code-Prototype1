using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private vars
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FIXME: add code to make the truck go forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //forward motion controlled by player input. max is 20m/s
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //Vector3.forward => 1 m / frame. Time.deltaTime = frame/second, so Vector3.forward * Time.deltaTime = 1 m / second. this*speed is speed limit of vehicle
        //left and right motion controlled by player input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
