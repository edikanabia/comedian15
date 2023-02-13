using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    Rigidbody2D tomatoBody;
    public float force;
    bool isThrown = false;

    // Start is called before the first frame update
    void Start()
    {
        tomatoBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (!isThrown)
        {
            force = Random.Range(35f, 75f);
            tomatoBody.AddForce(new Vector2(Random.Range(-.5f, .5f), Random.Range(-.5f, .5f)) * force, ForceMode2D.Impulse);
        }
        isThrown = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
