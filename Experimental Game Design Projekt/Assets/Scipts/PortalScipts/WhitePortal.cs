using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            playerColor.setWhite();
        }
    }
}
