using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private PlayerColor playerColor;
    private Rigidbody2D rigidbody2D;
    [SerializeField] float spawnPointX = 0;
    [SerializeField] float spawnPointY = 0;

    void Start(){
        playerColor = GetComponent<PlayerColor>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Spike"){
            playerColor.setWhite();
            this.transform.position = new Vector2(spawnPointX, spawnPointY);
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.angularVelocity = 0;
        }
    }



}
