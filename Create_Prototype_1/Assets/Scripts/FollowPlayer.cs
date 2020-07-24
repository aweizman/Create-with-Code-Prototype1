using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    public UnityEngine.Vector3 offset = new UnityEngine.Vector3(0, 5, -7);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
