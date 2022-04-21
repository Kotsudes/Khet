using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub : MonoBehaviour{

    public static Pawn selectedPiece;

    public void MoveUp(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Translation("NORTH");
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }

     public void MoveDown(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Translation("SOUTH");
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }

     public void MoveWest(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Translation("WEST");
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }

     public void MoveEast(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Translation("EAST");
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }

     public void RotateLeft(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Rotate(false);
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }

     public void RotateRight(){
        if(selectedPiece == null) return;
        bool result = selectedPiece.Rotate(true);
        if(result){
            Debug.Log("Success");
        }
        else Debug.Log("Failure");
    }
}
