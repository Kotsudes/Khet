using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class Mirror : Pawn
{

    public string orientation = "NORTH";    

    public override bool Rotate(bool useless){
        if(Hub.selectedPiece != this){
            return false;
        }
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
            switch (orientation){
                case "NORTH":
                    orientation = "SOUTH";
                    break;
                case "SOUTH":
                    orientation = "NORTH";
                    break;
            }
        Hub.selectedPiece = null;
        return true;
    }


    // Start is called before the first frame update
    void Start()
    {
        gridBoard = GameObject.Find("Board").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
