using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSlow : MonoBehaviour
{



    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            //print("Slow Player");
            other.GetComponent<PlayerMovementScript>().slowPlayerMovement();
        }
    }
}
