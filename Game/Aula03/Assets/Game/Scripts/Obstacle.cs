using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D objRB;

    void Start()
    {
        objRB = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        objRB.velocity = new Vector2(-5f, 0f);
    }
}
