using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    
   
    void Start()
    {     
        StartCoroutine(HardLoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HardLoadScene(){
         yield return new WaitForSeconds(32);
         SceneManager.LoadScene(1);


    }
}
