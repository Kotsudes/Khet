using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Laser : MonoBehaviour
{
    public Tilemap gridBoard;
    public Tile[] straightLaser;
    public Tile[] curvedLaser;
    public Vector3Int position;

    public string direction;
    public string type;
    public void spawnLaser(int player){
        switch (player){
            case 1:
                direction = "NORTH";
                position = new Vector3Int(9,-7,0);
                break;
            case 2:
                direction = "SOUTH";
                position = new Vector3Int(0,0,0);
                break;
            default:
                return;
        }
        laserBehavior();
    }

    public void laserBehavior(){
        move();
        if(detection() == false){
            gridBoard.ClearAllTiles();
            return;
        }
        draw();
    }

    public bool move(){
        switch (direction){
            case "NORTH":
                position += new Vector3Int(0,1,0);
                break;
            case "WEST":
                position += new Vector3Int(-1,0,0);
                break;
            case "SOUTH":
                position += new Vector3Int(0,-1,0);
                break;
            case "EAST":
                position += new Vector3Int(1,0,0);
                break;
        }


        return false;
    }

    public bool detection(){
        return true;
    }

    public void draw(){
        switch (type)
        {
            case "STRAIGHT":
                if(direction == "NORTH" | direction == "SOUTH"){
                    int variation = Random.Range(0, 5);
                    Tile temp = straightLaser[variation];
                    gridBoard.SetTile(position,temp);
                }
                else{
                    int variation = Random.Range(5, 10);
                    Tile temp = straightLaser[variation];
                    gridBoard.SetTile(position,temp);
                }
                break;
            case "CURVED":

                break;
        }
        
    }




    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        
    }
}
