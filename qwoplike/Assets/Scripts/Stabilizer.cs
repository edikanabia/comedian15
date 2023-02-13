using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilizer : MonoBehaviour
{
    GameManager gameManager;
    BodyScript body;

    Rigidbody2D stabilizerBody;
    public float power;
    public KeyCode stabilizerKey;
    public bool isCharging = false;

    private float previousRotation;

    // Start is called before the first frame update
    void Start()
    {
        stabilizerBody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        body = GetComponentInParent<BodyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (!gameManager.gameEnd)
        {
            if (Input.GetKeyDown(stabilizerKey))
            {
                
                previousRotation = stabilizerBody.rotation;
                isCharging = true;
            }

            if (Input.GetKey(stabilizerKey))
            {
                //we want to slow the body's rotation...
                //stabilizerBody.SetRotation(previousRotation);

                stabilizerBody.MoveRotation(previousRotation);

            }
            if (Input.GetKeyUp(stabilizerKey))
            {
                
                power = Random.Range(6f, 15f);
                stabilizerBody.AddForce(transform.up * power, ForceMode2D.Impulse);
                isCharging = false;
            }
        }
    }
}
