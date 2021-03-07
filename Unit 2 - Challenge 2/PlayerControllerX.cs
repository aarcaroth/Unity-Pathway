﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogSpawnInterval = 1;

    private float timeSinceKeyPress;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > timeSinceKeyPress))
        {
            // add one second when dog is created
            timeSinceKeyPress = Time.time + dogSpawnInterval;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
