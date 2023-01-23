using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float forceAmount = 0;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W Pressed");
            rb.AddForce(0, 0, forceAmount);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S Pressed");
            rb.AddForce(0, 0, -forceAmount);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A Pressed");
            rb.AddForce(-forceAmount, 0, 0 );
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D Pressed");
            rb.AddForce(forceAmount, 0, 0 );
        }
    }
}
