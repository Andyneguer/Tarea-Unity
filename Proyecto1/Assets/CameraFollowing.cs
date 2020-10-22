﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0f, 0f, -20f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x,0f,0f) + offset; 
    }
}