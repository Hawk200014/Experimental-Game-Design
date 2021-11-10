using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Transform playerTransform;
    [SerializeField] float movespeed = 100f;
    [SerializeField][Range(1,300)] float veloMulti = 150;
    private bool playerHitted;
    private bool slowPlayer;

    //Displayed Variables
    [SerializeField] float velocityX;
    [SerializeField] float velocityY;
    [SerializeField] Vector2 mousePos;
    [SerializeField] Vector2 playerPos;
    [SerializeField] float playerSlowFactor = 0.5f;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        slowPlayer = false;
    }

    /*
    * 
    */
    void Update()
    {
        this.velocityX = playerRigidbody2D.velocity.x;
        this.velocityY = playerRigidbody2D.velocity.y;
        this.mousePos = Input.mousePosition;
        this.playerPos = playerRigidbody2D.position;

        if(slowPlayer){
            playerRigidbody2D.AddForce(new Vector2(-velocityX*0.5f, 0f));       
        }

        if(velocityX < 0.05f && velocityX > -0.05 && velocityX != 0){
            playerRigidbody2D.velocity = new Vector2(0f, velocityY);
            
        }



        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null){
                if(velocityX == 0 && velocityY == 0) {
                    if(hit.transform.name == "Player"){
                        playerHitted = true;
                    }
                    else{
                        playerHitted = false;
                    }
                }
            }
        }
        if(Input.GetMouseButtonUp(0)){
            if(playerHitted){
                slowPlayer = false;
                playerHitted = false;
                playerRigidbody2D.gravityScale = 1;
                forceToPlayer(Input.mousePosition);
            }
        }
    }


    //Verlangsamt Player, wenn er den Ground berührt
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Ground"){
            slowPlayer = true;
        }
    }




    /*
    * Rechnet den Vector zwichen dem Player und der Mausposition aus
    * und beschleunigt mit den werden den Spieler
    */
    private void forceToPlayer(Vector3 mousePos){
        Vector2 translatedMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 force = new Vector2(playerTransform.position.x - translatedMousePos.x, playerTransform.position.y-translatedMousePos.y);
        playerRigidbody2D.AddForce(force*veloMulti);
    }


}
