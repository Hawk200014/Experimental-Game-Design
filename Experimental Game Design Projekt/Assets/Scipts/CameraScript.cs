using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform playerTransform;
    [SerializeField] float speed;
    public static bool player_controls_camera;

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
            this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
            player_controls_camera = false;
        }




    }
}
