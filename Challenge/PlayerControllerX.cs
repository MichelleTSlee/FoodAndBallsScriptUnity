using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeDelay = 1.0f;
    private float timestamp;

    // Update is called once per frame
    void Update()
    {
        // Press spacebar, send dog, there is a time delay
        if (Time.time >= timestamp && (Input.GetKeyDown(KeyCode.Space)))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + timeDelay;
        }
    }
}
