using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Transform playerTransform;
    [SerializeField] float movespeed = 100f;
    [SerializeField][Range(1,300)] float veloMulti = 150;
    public bool playerHitted;
    private bool slowPlayer;
    [SerializeField] AudioSource audioSource;

    private ThrowLine line;

    //Displayed Variables
    [SerializeField] float velocityX;
    [SerializeField] float velocityY;
    [SerializeField] Vector2 mousePos;
    [SerializeField] Vector2 playerPos;
    private Vector2 force;
    [SerializeField] float playerSlowFactor = 0.5f;

    void Start()
    {
        line = GetComponent<ThrowLine>();
        audioSource = GetComponent<AudioSource>();
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


        if(velocityX < 0.1f && velocityX > -0.1f && velocityX != 0){
            playerRigidbody2D.velocity = new Vector2(0f, velocityY);
        }

        if(slowPlayer){
            print("Slow Force");
            print(new Vector2(-velocityX*0.5f, 0f));
            print(playerRigidbody2D.velocity.x);
            playerRigidbody2D.AddForce(new Vector2(-velocityX*playerSlowFactor, 0f));       
        }
        if(playerRigidbody2D.velocity.x == 0){
            slowPlayer = false;
        }
        Vector2 translatedMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        force = new Vector2(playerTransform.position.x - translatedMousePos.x, playerTransform.position.y-translatedMousePos.y);

        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null){
                if(velocityX < 0.01f && velocityY < 0.01f && velocityX > -0.01f && velocityY > -0.01f) {
                    if(hit.transform.name == "Player"){
                        playerHitted = true;
                        line.showLine();
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
                line.hideLines();
            }
        }
    }


    public void slowPlayerMovement(){
        slowPlayer = true;
    }

    public bool getPlayerHit(){
        return playerHitted;
    }

    public Vector3 getRelativMousePos(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    /*
    * Rechnet den Vector zwichen dem Player und der Mausposition aus
    * und beschleunigt mit den werden den Spieler
    */
    private void forceToPlayer(Vector3 mousePos){
        if(Juice.getJuice() > 0){
            audioSource.Play();
        }
        playerRigidbody2D.AddForce(force*veloMulti);
    }

    public Vector2 getForce(){
        return force;
    }

}
