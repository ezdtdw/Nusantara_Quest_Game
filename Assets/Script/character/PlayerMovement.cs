using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;
    public LayerMask groundLayer;
    private bool isGrounded;
    public Transform feetPosition;
    public float groundCheckRadius;
    public float jumpTime = 0.35f;
    public float jumpTimeCounter;
    private bool isJumping;


    void Start() {
        playerRb.freezeRotation = true;
    }

    void Update(){
        input = Input.GetAxisRaw("Horizontal");
        if(input > 0){
            spriteRenderer.flipX = false;
        } else if(input < 0){
            spriteRenderer.flipX = true;
        }

        /*if (Input.GetKeyDown(KeyCode.Space)){
            playerRb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }*/

        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckRadius, groundLayer);

        if (isGrounded == true && Input.GetButtonDown("Jump")){
            isJumping = true;
            jumpTimeCounter = jumpTime;
            playerRb.linearVelocity = Vector2.up * jumpForce;
        }
        if (Input.GetButton("Jump")  && isJumping == true){
        
            if(jumpTimeCounter > 0){
                playerRb.linearVelocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            } else {
                isJumping = false;
            }
        } 
        if (Input.GetButtonUp("Jump")){
            isJumping = false;
        }
    }
    void FixedUpdate()
    {
        playerRb.linearVelocity = new Vector2(input * speed, playerRb.linearVelocity.y);
    }
}