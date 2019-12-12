﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
