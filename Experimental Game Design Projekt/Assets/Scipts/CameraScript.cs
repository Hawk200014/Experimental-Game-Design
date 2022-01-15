using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform playerTransform;
    [SerializeField] float speed;
    public static bool player_controls_camera;
    private bool changeCamera = false;
    [SerializeField] float CameraMoveSpeed = 10;
    bool player_moving_camera = false;
    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
       
            
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            player_controls_camera = true;
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            }
        }
        else
        {
            if(!changeCamera){
                this.transform.position = new Vector3(playerTransform.transform.position.x, playerTransform.transform.position.y+(float)0.8, -10);
            }
            else{
                this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(playerTransform.transform.position.x, playerTransform.transform.position.y, -10f), CameraMoveSpeed*Time.deltaTime);
                float diffx = transform.position.x - playerTransform.transform.position.x;
                float diffy = transform.position.y - playerTransform.transform.position.y;
                print("DiffPos: " + diffx + " : " + diffy);
                if(diffx < 0.01f && diffx > -0.01f && diffy < 0.01f && diffy > -0.01f){
                    changeCamera = false;
                }
            }
            player_controls_camera = false;
        }


    }
    public void setPlayer(GameObject player){
        playerTransform = player.transform;
    }

    public void RespawnCameraMovement(){
        print("RespawnCamera");
        changeCamera = true;
    }
}
