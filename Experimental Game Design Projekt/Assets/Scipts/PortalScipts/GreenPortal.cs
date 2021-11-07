using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            playerColor.setGreen();
        }
    }
}
