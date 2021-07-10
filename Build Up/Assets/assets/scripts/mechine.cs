using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechine : MonoBehaviour
{
    
    public GameObject[] Blocks;

    public GameObject SpwanPos;

    public float DropSpeed = 8;

    GameManager gameManager;


    void Start()
    {
        int randomBlocks = Random.Range(0, Blocks.Length);
        gameManager = GameObject.Find("game manager").GetComponent<GameManager>();
        Instantiate(Blocks[randomBlocks] , new Vector3(SpwanPos.transform.position.x , SpwanPos.transform.position.y, -4) , transform.rotation);
        StartCoroutine(ThrowBlocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ThrowBlocks(){
        yield return new WaitForSeconds(DropSpeed);
        int randomBlocks = Random.Range(0, Blocks.Length);
       // if(gameManager.Pause == false){
                Instantiate(Blocks[randomBlocks] , new Vector3(SpwanPos.transform.position.x , SpwanPos.transform.position.y, -4) , transform.rotation);
     //   }      
        StartCoroutine(ThrowBlocks());
        
    }
}
