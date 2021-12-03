using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private PlayerColor playerColor;
    private Rigidbody2D rigidbody2D;
    [SerializeField] float spawnPointX = 0;
    [SerializeField] float spawnPointY = 0;
    [SerializeField] GameObject PlayerCon;
    private PlayereController playerControllerScript;

    private PlayerActiv playerActiv;

    void Start(){
        playerColor = GetComponent<PlayerColor>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        PlayerCon = GameObject.Find("PlayerCon");
        playerControllerScript =  PlayerCon.GetComponent<PlayereController>();
        playerActiv = GetComponent<PlayerActiv>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Spike" && playerActiv.getActive()){
            playerColor.setWhite();
            playerControllerScript.Respawn();
        }
    }



}
