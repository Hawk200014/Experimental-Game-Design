using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayereController : MonoBehaviour
{
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject Camera;
    private ArrayList InactivePlayers;
    [SerializeField] GameObject ActivPlayer;
    [SerializeField] GameObject RespawnPoint;
    private int MaxPlayers;

    private CameraScript cameraScript;



    private void Start(){
        setMaxPlayers(100);
        InactivePlayers = new ArrayList();
        print("InitPlayer");
        ActivPlayer = Instantiate(PlayerPrefab, RespawnPoint.transform.position, RespawnPoint.transform.rotation);
        cameraScript = Camera.GetComponent<CameraScript>();
        cameraScript.setPlayer(ActivPlayer);
    }

    public void setMaxPlayers(int maxplayers){
        MaxPlayers = maxplayers;
    }

    public int countPlayers(){
        return InactivePlayers.Count + 1;
    }

    private void setInactive(){
        ActivPlayer.GetComponent<PlayerActiv>().setInactive();
        InactivePlayers.Add(ActivPlayer);
    }

    public void newPlayer(){
        if(countPlayers() <= MaxPlayers){
            setInactive();
            ActivPlayer = Instantiate(PlayerPrefab, RespawnPoint.transform.position, RespawnPoint.transform.rotation);
            cameraScript.setPlayer(ActivPlayer);
            cameraScript.RespawnCameraMovement();
        }
    }

    public GameObject getActivPlayer(){
        return ActivPlayer;
    }


    public void Respawn(){

        ActivPlayer.transform.position = RespawnPoint.transform.position;
        ActivPlayer.transform.rotation = RespawnPoint.transform.rotation;
        Camera.GetComponent<CameraScript>().RespawnCameraMovement();
        ActivPlayer.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        ActivPlayer.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    
    }


    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            newPlayer();
        }
        cameraScript.setPlayer(ActivPlayer);
    }




}