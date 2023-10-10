﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float sendSpeed = 1.5f;
    private float nextSend = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSend)
        {
            nextSend = Time.time + sendSpeed;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
