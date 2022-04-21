using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Reflector : Pawn
{
    public string orientation = "NORTH";
    public override bool Rotate(bool isClockwise){
        if(Hub.selectedPiece != this){
            return false;
        }
        if(!isClockwise){
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
            switch (orientation){
                case "NORTH":
                    orientation = "WEST";
                    break;
                case "WEST":
                    orientation = "SOUTH";
                    break;
                case "SOUTH":
                    orientation = "EAST";
                    break;
                case "EAST":
                    orientation = "NORTH";
                    break;
            }
        }
        else{ 
            transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
            switch (orientation){
                case "NORTH":
                    orientation = "EAST";
                    break;
                case "WEST":
                    orientation = "NORTH";
                    break;
                case "SOUTH":
                    orientation = "WEST";
                    break;
                case "EAST":
                    this.orientation = "NORTH";
                    break;
            }
        }
        Hub.selectedPiece = null;
        return true;
    }


    // Start is called before the first frame update
    void Start(){
        gridBoard = GameObject.Find("Board").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update(){

    }
}
