using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heckler : MonoBehaviour   
{
    //the heckler is responsible for spawning ("throwing") the tomato.

    Tomato tomatoScript;
    public GameObject tomato;
    public Vector2 spawnPosition;
    public float countdown;
    public float maxCountdown;

    // Start is called before the first frame update
    void Start()
    {
        tomatoScript = tomato.GetComponent<Tomato>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0)
        {
            ThrowTomato();
            countdown = maxCountdown;
        }
    }

    public void ThrowTomato()
    {
        Instantiate(tomato,spawnPosition,Quaternion.identity);
        
    }
}
