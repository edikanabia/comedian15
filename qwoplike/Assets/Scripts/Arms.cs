using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{

    HingeJoint2D hinge;
    public KeyCode hingeKey;

    // Start is called before the first frame update
    void Start()
    {

        hinge = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hingeKey))
        {
            hinge.useMotor = true;
            
        }
        else if (Input.GetKeyUp(hingeKey))
        {
            hinge.useMotor = false;
        }
    }
}
