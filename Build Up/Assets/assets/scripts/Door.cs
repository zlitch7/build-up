using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    
    public GameObject BlackScreen;

    void Start()
    {
        BlackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            Debug.Log("game over");
            BlackScreen.SetActive(true);
            StartCoroutine(EndScene());
        }
    }

    IEnumerator EndScene(){
      yield return new WaitForSeconds(2);
      SceneManager.LoadScene(4);     
    }
}
