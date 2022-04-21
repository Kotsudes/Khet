using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Reflector : Pawn
{

    public override bool Rotate(bool isClockwise){
        return false;
    }


    // Start is called before the first frame update
    void Start(){
        gridBoard = GameObject.Find("Board").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update(){

    }

     /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown(){
        Hub.selectedPiece = this;
    }
}
