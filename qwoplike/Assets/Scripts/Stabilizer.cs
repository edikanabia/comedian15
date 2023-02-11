using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilizer : MonoBehaviour
{
    Rigidbody2D stabilizerBody;
    public float power;
    public KeyCode stabilizerKey;


    private float previousRotation;

    // Start is called before the first frame update
    void Start()
    {
        stabilizerBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(stabilizerKey))
        {
            previousRotation = stabilizerBody.rotation;
        }
        
        if (Input.GetKey(stabilizerKey))
        {
            //we want to slow the body's rotation...
            //stabilizerBody.SetRotation(previousRotation);
            
            stabilizerBody.MoveRotation(previousRotation);
            
        }
    }
}
