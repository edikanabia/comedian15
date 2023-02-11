using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public KeyCode boostKey;
    
    Rigidbody2D boosterBody;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        boosterBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(boostKey))
        {
            power = Random.Range(6f, 15f);
            boosterBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }

    }
}
