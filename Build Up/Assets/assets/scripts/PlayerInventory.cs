using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    
    public TextMeshProUGUI blockCountText;
    public TextMeshProUGUI StarText;
    public int blockCount;
    public int stars;
    public bool canPick = true;
    public float InventorySpace = 3;

    void Start()
    {
        blockCountText = GameObject.Find("block count text").GetComponent<TextMeshProUGUI>();
        StarText = GameObject.Find("star text").GetComponent<TextMeshProUGUI>();
        stars = 0;
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
