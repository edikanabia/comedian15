using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{

    Rigidbody2D thrusterBody;
    public float power;
    public KeyCode thrusterKey;

    // Start is called before the first frame update
    void Start()
    {
        thrusterBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(thrusterKey))
        {
            //every time you press the thruster, the force is different.
            power = Random.Range(1f, 5f);
            
        }

        if (Input.GetKey(thrusterKey))
        {
            thrusterBody.AddForce(transform.up * power, ForceMode2D.Force);
        }
    }
}
