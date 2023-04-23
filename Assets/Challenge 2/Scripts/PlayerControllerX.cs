using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float lastTime;
    public float timeBetweenDogs = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //If the difference between the current time and last time is greater than the set time
        //allow for spacebar
        if ((Time.time - lastTime) > timeBetweenDogs)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                //Set the lastTime to the current time
                lastTime = Time.time;
            }
        }
    }
}