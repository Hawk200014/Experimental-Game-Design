using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWallColliding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    private void OnTriggerEnter2D( Collider2D other){
        print("Yellow Wall Collided");
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            if(playerColor.getColor() == 'Y'){
                print("Farbe vom Spieler ist Gelb");
                Rigidbody2D rigidbody2D = other.GetComponent<Rigidbody2D>();
                rigidbody2D.velocity = new Vector2(0f,0f);
                rigidbody2D.gravityScale = 0;
            }
            else{
                print("Farbe vom Spieler ist nicht Gelb");
            }

        }
    }
}
