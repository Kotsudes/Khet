using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class Pawn : MonoBehaviour
{
    public float speed = 5f;
    public Tilemap gridBoard;

    public Pawn[,] gridPawn = new Pawn[10,8];

    public abstract bool Rotate(bool isClockwise);

     /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown(){
        Hub.selectedPiece = this;
    }

    public bool Translation(string direction){
        if(Hub.selectedPiece == this){
            string name;
            bool test = false;
            switch (direction){
                case "NORTH":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(0, 1, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(0, 1, 0);
                        test = true;
                    }
                    break;
                case "SOUTH":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(0, -1, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(0, -1, 0);
                        test = true;
                    }
                    break;
                case "WEST":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(-1, 0, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(-1, 0, 0);
                        test = true;
                    }
                    break;
                case "EAST":
                    name = gridBoard.GetTile( Vector3Int.FloorToInt(transform.position) + new Vector3Int(1, 0, 0)).name;
                    if(name == "Board and Pieces_14" | name == "Board and Pieces_12" | name == "Board and Pieces_20"){
                        transform.position = transform.position +  new Vector3Int(1, 0, 0);
                        test = true;
                    }
                    break;  
            }
            Hub.selectedPiece = null;
            return test;
        }
        return false;
    }
}
