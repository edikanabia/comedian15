using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{
    GameManager gameManager;

    HingeJoint2D[] hinges;
    public KeyCode hingeKeyL;
    public KeyCode hingeKeyR;

    // Start is called before the first frame update
    void Start()
    {
        hinges = GetComponents<HingeJoint2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    private void FixedUpdate()
    {
        if (!gameManager.gameEnd)
        {
            if (Input.GetKeyDown(hingeKeyL))
            {
                hinges[0].useMotor = true;


            }
            if (Input.GetKeyUp(hingeKeyL))
            {

                hinges[0].useMotor = false;

            }

            if (Input.GetKeyDown(hingeKeyR))
            {
                hinges[1].useMotor = true;


            }
            if (Input.GetKeyUp(hingeKeyR))
            {

                hinges[1].useMotor = false;

            }
        }
    }
}
