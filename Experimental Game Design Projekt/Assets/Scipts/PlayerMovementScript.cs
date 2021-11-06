using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Transform playerTransform;
    [SerializeField] float movespeed = 100f;
    [SerializeField] float veloX;
    [SerializeField][Range(1,20)] float veloMulti = 1;

    [SerializeField] Vector2 mousePos;
    [SerializeField] Vector2 playerPos;
    private bool playerHitted;



    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();

    }

    /*

    */
    void Update()
    {
        this.veloX = rigidbody2D.velocity.x;
        this.mousePos = Input.mousePosition;
        this.playerPos = rigidbody2D.position;

        if(Input.GetMouseButtonDown(0)){
            //print("Maustaste wurde gedrückt");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null){
                if(hit.transform.name == "Player"){
                    //print("Player Hit");
                    playerHitted = true;
                }
                else{
                    playerHitted = false;
                }
                //print("Object hit: " + hit.transform.name);
            }
        }
        if(Input.GetMouseButtonUp(0)){
            //print("Maustaste Hoch");
            if(playerHitted){
                print("Player gezogen");
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
        Vector2 force = new Vector2(mousePos.x-playerTransform.position.x, mousePos.y-playerTransform.position.y);
        print("MausPos " + mousePos);
        print("PlayerPos" + playerTransform.position);
        print("Force " + force);
        rigidbody2D.AddForce(force);
    }


}
