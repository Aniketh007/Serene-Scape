using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward* turnspeed*horizontalInput*Time.deltaTime);
        transform.Rotate(Vector3.up, turnspeed*horizontalInput*Time.deltaTime);
        
    }
}
