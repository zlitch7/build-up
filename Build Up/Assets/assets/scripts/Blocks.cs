using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

    public PlayerInventory playerInventory;

    public Collider2D col2D;

    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
           Destroy(gameObject);
           playerInventory.blockCount += 1;
           playerInventory.blockCountText.text  = playerInventory.blockCount.ToString();
        }
    }

   // void OnTriggerEnter2D(Collision)
    
}
