using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public GameObject Shop;
    public GameObject Tutorial;
    public GameObject Tutorial2;

    public bool Pause = false;

    void Start()
    {
        Tutorial.SetActive(true);
        Tutorial2.SetActive(false);
        StartCoroutine(StopTutorial());
        Shop.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StopTutorial(){
        yield return new WaitForSeconds(10);
        Tutorial.SetActive(false);
        Tutorial2.SetActive(true);
        StartCoroutine(stopTuorial2());
    }

    IEnumerator stopTuorial2(){
        yield return new WaitForSeconds(10);
        Tutorial2.SetActive(false);
    }

    public void ShopButton(){

         Shop.SetActive(true);
         Pause = true;

    }

    public void closeButton(){
        Shop.SetActive(false);
        Pause = false;
    }
 
    public void Retry(){
        SceneManager.LoadScene(1);
    }

    public void EasyMode(){
        SceneManager.LoadScene(2);
    }

}
