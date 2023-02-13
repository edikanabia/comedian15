using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{

    HingeJoint2D hinge;
    public KeyCode hingeKey;
    float motorSpeed;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motorSpeed = hinge.motor.motorSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(hingeKey))
        {
            hinge.useMotor = true;
            hinge.motor.motorSpeed.Equals(motorSpeed);
            
        }
        if (Input.GetKeyUp(hingeKey))
        {

            hinge.useMotor = false;

        }
    }
}
