﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMovement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < 5)
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
