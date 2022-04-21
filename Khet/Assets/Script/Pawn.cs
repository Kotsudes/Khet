using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class Pawn : MonoBehaviour
{
    public string orientation = "North";
    public float speed = 5f;
    public Tilemap gridBoard;

    public abstract bool Rotate(bool isClockwise);

    public bool Translation(string direction){
        if(Hub.selectedPiece == this){
            string name;
            switch (direction){
                case "NORTH":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(0, 1, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(0, 1, 0);
                    }
                    break;
                case "SOUTH":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(0, -1, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(0, -1, 0);
                    }
                    break;
                case "WEST":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(-1, 0, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(-1, 0, 0);
                    }
                    break;
                case "EAST":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(1, 0, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(1, 0, 0);
                    }
                    break;  
            }
            Hub.selectedPiece = null;
            return true;
        }
        return false;
    }
}
