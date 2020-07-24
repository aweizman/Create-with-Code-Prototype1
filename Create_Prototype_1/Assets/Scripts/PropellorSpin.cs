using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorSpin : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed = 50.0f;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
