﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{

    void Update()
    {
        if (gameObject.transform.position.z < -10)
        {
            Destroy(gameObject); 
        }
    }
}
