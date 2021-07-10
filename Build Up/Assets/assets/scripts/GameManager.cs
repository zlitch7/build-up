using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject Shop;

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

    }

    public void closeButton(){
        Shop.SetActive(false);
    }
}
