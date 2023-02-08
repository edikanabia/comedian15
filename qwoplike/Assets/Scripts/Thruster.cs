using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{

    Rigidbody2D thrusterBody;
    public float power;
    public KeyCode thrusterKey;
    public ForceMode2D mode2D;
    public float xAngle;
    Vector3 forceAngle;

    // Start is called before the first frame update
    void Start()
    {
        thrusterBody = GetComponent<Rigidbody2D>();
        forceAngle = new Vector3(xAngle, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(thrusterKey))
        {
            //every time you press the thruster, the force is different.
            //power = Random.Range(2f, 8f);
            
        }

        if (Input.GetKey(thrusterKey))
        {
            thrusterBody.AddForce(forceAngle * power, mode2D);
        }
    }
}
