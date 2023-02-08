using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilizer : MonoBehaviour
{
    Rigidbody2D stabilizerBody;
    public float power;
    public KeyCode stabilizerKey;
    public float angle;

    public Vector3 forceAngle;

    // Start is called before the first frame update
    void Start()
    {
        stabilizerBody = GetComponent<Rigidbody2D>();
        forceAngle = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(stabilizerKey))
        {

        }
    }
}
