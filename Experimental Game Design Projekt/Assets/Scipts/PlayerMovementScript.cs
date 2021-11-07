using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Transform playerTransform;
    [SerializeField] float movespeed = 100f;
    [SerializeField][Range(1,100)] float veloMulti = 1;
    private bool playerHitted;

    //Displayed Variables
    [SerializeField] float velocityX;
    [SerializeField] float velocityY;
    [SerializeField] Vector2 mousePos;
    [SerializeField] Vector2 playerPos;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
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
        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null){
                if(velocityX > 0.05f || velocityY > 0.05f) return;
                if(hit.transform.name == "Player"){
                    playerHitted = true;
                }
                else{
                    playerHitted = false;
                }
            }
        }
        if(Input.GetMouseButtonUp(0)){
            if(playerHitted){
                playerHitted = false;
                forceToPlayer(Input.mousePosition);
            }
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
