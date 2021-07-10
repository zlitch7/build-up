using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

    public PlayerInventory playerInventory;
    Rigidbody2D BlockRb;

    public float minForce = 1;
    public float MaxForce = 3;

    

    void Start()
    {
        float randomForce = Random.Range(minForce , MaxForce);

        BlockRb = GetComponent<Rigidbody2D>();
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        BlockRb.AddForce( new Vector2 (randomForce ,0), ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player") && playerInventory.canPick == true ){
           Destroy(gameObject);
           playerInventory.blockCount += 1;
           playerInventory.blockCountText.text  = playerInventory.blockCount.ToString();
        }
    }

   // void OnTriggerEnter2D(Collision)
    
}
