using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;

    public GameObject CheckGroundObj;
    public float CheckGroundDistance;
    public LayerMask CheckGroundLayer;

    private  float horizontalInput;
    public float speed;
    public float JumpSpeed;
    public bool isGrounded;
    private bool facingRight = true;

    private float jumpTimeCounter;
    public float JumpTime;
    private bool isJumping;

    private Vector2 workSpace;
    private Vector2 currentVelocity;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        getInput();
        jump();
        isGrounded = CheckIfGrounded();
    }

    void FixedUpdate(){

         Movement();
         if(facingRight == false && horizontalInput > 0){
             Flip();
         }
         else if(facingRight == true && horizontalInput < 0){
             Flip();
         }
    }

    public void getInput(){
        
        horizontalInput = Input.GetAxis("Horizontal");
    }

    public void Movement(){

      rb.velocity = new Vector2( horizontalInput * speed , rb.velocity.y);

    }

    public void jump(){
        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true){
            rb.velocity = Vector2.up * JumpSpeed;
            isJumping = true;
            jumpTimeCounter = JumpTime;
        }

        if(Input.GetKey(KeyCode.Space) && isJumping == true){
            if(jumpTimeCounter > 0){
               rb.velocity = Vector2.up * JumpSpeed;
               jumpTimeCounter -= Time.deltaTime;
            }  
            else {
                isJumping = false;
            }         
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            isJumping = false;
        }
    }

    public void Flip(){

      facingRight = !facingRight;
      Vector3 scale = transform.localScale;
      scale.x *= -1;
      transform.localScale = scale;
         
    }

     public bool CheckIfGrounded()
    {
       return Physics2D.OverlapCircle(CheckGroundObj.transform.position , CheckGroundDistance, CheckGroundLayer);
    }

    public void OnDrawGizmos(){
        Gizmos.DrawWireSphere(CheckGroundObj.transform.position , CheckGroundDistance);
    }



}

