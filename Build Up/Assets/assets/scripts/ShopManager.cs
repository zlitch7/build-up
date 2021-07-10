using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public PlayerController playerController;
    public GameObject SpeedLevel1 ,SpeedLevel2, SpeedLevel3,  SpeedLevel4;
    public GameObject JumpLevel1, JumpLevel2, JumpLevel3, JumpLevel4;
    private bool bsl1 = false , bsl2 = false , bsl3 = false, bls4 = false;
    private bool bjl1 = false, bjl2 = false, bjl3 = false, bjl4  = false;

    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
        SpeedLevel2.SetActive(false);
        SpeedLevel3.SetActive(false);
        SpeedLevel4.SetActive(false);

        JumpLevel2.SetActive(false);
        JumpLevel3.SetActive(false);
        JumpLevel4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#region  Speed

    public void level1Speed(){
        if(playerInventory.stars >= 1 && bsl1 == false){
             SpeedLevel2.SetActive(true);
             bsl1 = true;
             playerController.speed += 1;
             playerInventory.stars -= 1;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    }

     public void level2Speed(){
        if(playerInventory.stars >= 2 && bsl2 == false){
             SpeedLevel3.SetActive(true);
             bsl2 = true;
             playerController.speed += 1;
             playerInventory.stars -= 2;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    }

     public void level3Speed(){
        if(playerInventory.stars >= 3 && bsl3 == false){
             SpeedLevel4.SetActive(true);
             bsl3 = true;
             playerController.speed += 1;
             playerInventory.stars -= 3;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    }

     public void level4Speed(){
        if(playerInventory.stars >= 4 && bls4 == false){
             bls4 = true;
             playerController.speed += 1;
             playerInventory.stars -= 4;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    }
    #endregion

#region  Jump
    public void level1Jump(){
        if(playerInventory.stars >= 1 && bjl1 == false){
             JumpLevel2.SetActive(true);
             bjl1 = true;
             playerController.JumpSpeed += 1;
             playerInventory.stars -= 1;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    } 

      public void level2Jump(){
        if(playerInventory.stars >= 2 && bjl2 == false){
             JumpLevel3.SetActive(true);
             bjl2 = true;
             playerController.JumpSpeed += 1;
             playerInventory.stars -= 2;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    } 

      public void level3Jump(){
        if(playerInventory.stars >= 3 && bjl3 == false){
             JumpLevel4.SetActive(true);
             bjl3 = true;
             playerController.JumpSpeed += 1;
             playerInventory.stars -= 3;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    } 

      public void level4Jump(){
        if(playerInventory.stars >= 4 && bjl4 == false){
             bjl4 = true;
             playerController.JumpSpeed += 1;
             playerInventory.stars -= 4;
             playerInventory.StarText.text  = playerInventory.stars.ToString();
        }

    } 

#endregion    

}
