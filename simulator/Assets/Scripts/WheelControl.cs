using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl : MonoBehaviour
{
    public WheelCollider LW;
    public WheelCollider RW;
    public Transform leftWheel;
    public Transform rightWheel;
    public Transform centerOfMass;

    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
            /* Forward movement */
         if (Input.GetKey(KeyCode.UpArrow))
        {
            LW.motorTorque = speed;
            RW.motorTorque = speed;
        }
            /* Backward movement */
        if (Input.GetKey(KeyCode.DownArrow))
        {
            LW.motorTorque = -speed;
            RW.motorTorque = -speed;
        }
            /* Left movement */
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LW.motorTorque = 0f;
            RW.motorTorque = speed/1.2f;
        }
            /* Move right */
        if (Input.GetKey(KeyCode.RightArrow))
        {
            LW.motorTorque = speed/1.2f;
            RW.motorTorque = 0f;
        }
      
    }
}
