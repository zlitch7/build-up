using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
           // gameManager.Pause = true;
            Debug.Log("game over");
           // GameOver.SetActive(true);
        }
    }
}
