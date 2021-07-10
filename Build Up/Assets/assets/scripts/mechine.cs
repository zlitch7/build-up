using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechine : MonoBehaviour
{
    
    public GameObject yellowBlock;

    public GameObject SpwanPos;

    public float DropSpeed = 7;

    GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.Find("game manager").GetComponent<GameManager>();
        Instantiate(yellowBlock , new Vector3(SpwanPos.transform.position.x , SpwanPos.transform.position.y, -4) , transform.rotation);
        StartCoroutine(ThrowBlocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ThrowBlocks(){
        yield return new WaitForSeconds(DropSpeed);
        if(gameManager.Pause == false){
                Instantiate(yellowBlock , new Vector3(SpwanPos.transform.position.x , SpwanPos.transform.position.y, -4) , transform.rotation);
        }      
        StartCoroutine(ThrowBlocks());
        
    }
}
