using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWallColliding : MonoBehaviour
{


    private void OnTriggerEnter2D( Collider2D other){
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            if(playerColor.getColor() == 'Y'){
                Rigidbody2D rigidbody2D = other.GetComponent<Rigidbody2D>();
                rigidbody2D.velocity = new Vector2(0f,0f);
                rigidbody2D.gravityScale = 0;
            }
        }
    }
    
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }   
    
    private AudioSource audioSource;
    private void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            if(playerColor.getColor() == 'Y'){
                if(Juice.getJuice() > 0){
                    audioSource.Play();
                }
            }
        }
    }
}
