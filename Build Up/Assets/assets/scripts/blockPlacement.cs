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

     Vector3Int previousTile;

    void Start()
    {
        mainMap =  GameObject.Find("Main").GetComponent<Tilemap>();
        HighlightBlockMap =  GameObject.Find("HighlightMap").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        HighlightBlock();
        place();
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

        Vector3 point  = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0)){

            Vector3Int selectedTile = mainMap.WorldToCell(point);
            mainMap.SetTile(selectedTile , Block );
        }
       
    }

    public void Destory(){

         Vector3 point  = Camera.main.ScreenToWorldPoint(Input.mousePosition);

           if(Input.GetMouseButtonDown(1)){

            Vector3Int selectedTile = mainMap.WorldToCell(point);
            mainMap.SetTile(selectedTile , null );
        }
    }
}
