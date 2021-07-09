using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class blockPlacement : MonoBehaviour
{
    
    Tilemap mainMap;
    Tilemap HighlightBlockMap;
    public Tile Block;
    public Tile hlBlock;

    public GameObject YellowBlock;

    private Transform DropTransform;

    PlayerInventory playerInventory;

     Vector3Int previousTile;

    public BoxCollider2D Outcol2D;
    public BoxCollider2D Incol2D;

    void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        mainMap =  GameObject.Find("Main").GetComponent<Tilemap>();
        HighlightBlockMap =  GameObject.Find("HighlightMap").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        HighlightBlock();

        if(playerInventory.blockCount > 0){
             place();
            // playerInventory.blockCount -= 1;
        }
       
        

        Destory();
    }

    public void HighlightBlock(){

        Vector3 Firstpoint  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
         Vector3Int selectedTile = HighlightBlockMap.WorldToCell(Firstpoint);

              
        if(selectedTile != previousTile){
            HighlightBlockMap.SetTile(previousTile , null );
            HighlightBlockMap.SetTile(selectedTile , hlBlock );                         
            previousTile = selectedTile;
        }

    }

    public void place(){

       // Vector3 point  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
        if(Input.GetMouseButtonDown(0)){

         Vector3 point  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
          if(Outcol2D.OverlapPoint(point) && !Incol2D.OverlapPoint(point)){
              Debug.Log("doing");

                Vector3Int selectedTile = mainMap.WorldToCell(point);

                if(mainMap.HasTile(selectedTile)){
                    Debug.Log("already has a block");
                }
                else{
                    mainMap.SetTile(selectedTile , Block );
                    playerInventory.blockCount -= 1;
                    playerInventory.blockCountText.text  = playerInventory.blockCount.ToString();
                }
          }
          else{
              Debug.Log("not doing");
          }
        
        }       
    }

    public void Destory(){

        Vector3 point  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
        if(Input.GetMouseButtonDown(1)){           
            Vector3Int selectedTile = mainMap.WorldToCell(point);
            if(mainMap.HasTile(selectedTile)){
                mainMap.SetTile(selectedTile , null );
                Instantiate(YellowBlock , new Vector3( point.x , point.y , -4), transform.rotation);
            }
           
        }
    }
}
