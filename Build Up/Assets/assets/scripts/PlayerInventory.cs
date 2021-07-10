using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    
    public TextMeshProUGUI blockCountText;
    public int blockCount;
    public bool canPick = true;
    public float InventorySpace;

    void Start()
    {
        blockCountText = GameObject.Find("block count text").GetComponent<TextMeshProUGUI>();
      
        blockCount = 0;
    }

   
    void Update()
    {
        //blockCountText.text  = blockCount.ToString();
        if(blockCount >= InventorySpace){
            canPick = false;
        }  
        else if(blockCount < InventorySpace){
            canPick = true;
        }
        
    }
}
