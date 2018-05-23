﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Public variable to store a reference to the player game object
    public GameObject player;

    // Private variable to store the offset distance between the player and camera
    private Vector3 offset;


    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
