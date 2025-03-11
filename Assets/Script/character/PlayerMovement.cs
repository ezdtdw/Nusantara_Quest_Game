using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    float moveVelocity;
    bool grounded = true;

    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().linearVelocity = new Vector2(GetComponent<Rigidbody2D>().linearVelocity.x, jump);
            }

        float horiz = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(horiz * speed, GetComponent<Rigidbody2D>().linearVelocity.y);

        if(horiz > 0 || horiz < 0)
        {
            transform.localScale = new Vector2(0.6981f * horiz, 0.7344f);
        }
        
        }

        moveVelocity = 0;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().linearVelocity.y);
    }

    void OnTriggerEnter2D()
    {
        grounded = true;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}