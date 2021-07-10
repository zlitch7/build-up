using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject Shop;

    public bool Pause = false;

    void Start()
    {
        Shop.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShopButton(){

         Shop.SetActive(true);
         Pause = true;

    }

    public void closeButton(){
        Shop.SetActive(false);
        Pause = false;
    }
}
