using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mechine : MonoBehaviour
{
    
    public GameObject yellowBlock;

    public GameObject SpwanPos;


    void Start()
    {
      //  Instantiate(yellowBlock , SpwanPos.transform.position , transform.rotation);
        StartCoroutine(ThrowBlocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ThrowBlocks(){
        yield return new WaitForSeconds(5);
        Instantiate(yellowBlock , new Vector3(SpwanPos.transform.position.x , SpwanPos.transform.position.y, -4) , transform.rotation);
        StartCoroutine(ThrowBlocks());
        
    }
}
