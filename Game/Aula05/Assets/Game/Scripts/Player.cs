using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    public UnityEvent OnPlayerHitted;

    private Rigidbody2D plyRB;
    private Animator animator;
    private bool canJump;

    public float jumpFactor = 5f;
    public float forwardFactor = 0.2f;
    private float forwardForce = 0f;

    void Start()
    {

        plyRB = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        canJump = true;
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (canJump)
        {
            canJump = false;

            if(transform.position.x < 0)
            {
                forwardForce = forwardFactor;
            }
            else
            {
                forwardForce = 0f;
            }

            plyRB.velocity = new Vector2(forwardForce, jumpFactor);
            animator.Play("player_jumping");
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            plyRB.constraints = RigidbodyConstraints2D.FreezeAll;
            animator.Play("player_hurt");
            OnPlayerHitted.Invoke();
        }
        else
        {
            animator.Play("player_running");
        }

        canJump = true;
        
    }
}
