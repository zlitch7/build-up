using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public PlayerInventory playerInventory;

     AudioSource audioSource;
     public AudioClip bell;

    void Start()
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
           Destroy(gameObject);
           audioSource.PlayOneShot(bell);
           playerInventory.stars += 1;
           playerInventory.StarText.text  = playerInventory.stars.ToString();
        }
    }
}
