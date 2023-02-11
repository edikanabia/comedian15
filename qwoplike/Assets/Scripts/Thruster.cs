using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{

    Rigidbody2D thrusterBody;
    public float power;
    public KeyCode thrusterKey;
    public ForceMode2D mode2D;


    public bool isLeft;
    float rotationFactor;

    // Start is called before the first frame update
    void Start()
    {
        thrusterBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            rotationFactor = -1;
        }
        else
        {
            rotationFactor = 1;
        }

        if (Input.GetKeyDown(thrusterKey))
        {
            //every time you press the thruster, the force is different.
            //
            
        }

        if (Input.GetKey(thrusterKey))
        {
            thrusterBody.AddForce(transform.up * power, mode2D);
            //thrusterBody.MoveRotation((thrusterBody.rotation + rotationFactor) * power);
        }
    }
}
