using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyScript : MonoBehaviour
{
    GameManager gameManager;
    Rigidbody2D body;
    public bool isBoosting;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        body = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Enemy"))
        {
            gameManager.gameEnd = true;
            Debug.Log("OWIE");
        }
    }
}
