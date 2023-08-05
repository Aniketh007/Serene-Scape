using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float speed = 40;
    private float turnSpeed = 35;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*speed*forwardInput*Time.deltaTime);
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
        
    }
}
