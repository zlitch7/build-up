using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public PlayerInventory playerInventory;

    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
           Destroy(gameObject);
           playerInventory.stars += 1;
           playerInventory.StarText.text  = playerInventory.stars.ToString();
        }
    }
}
