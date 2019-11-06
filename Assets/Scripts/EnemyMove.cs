﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 1f, 1f);
        transform.Translate(0, 0, -speed*Time.deltaTime,Space.World);
        if (transform.position.z < -30.0f)
        {
            Destroy(gameObject);
        }
    }
}
