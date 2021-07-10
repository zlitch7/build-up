using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    
    public TextMeshProUGUI blockCountText;
    public int blockCount;

    void Start()
    {
        blockCountText = GameObject.Find("block count text").GetComponent<TextMeshProUGUI>();
        blockCount = 0;
    }

   
    void Update()
    {
        //blockCountText.text  = blockCount.ToString();
    }
}
