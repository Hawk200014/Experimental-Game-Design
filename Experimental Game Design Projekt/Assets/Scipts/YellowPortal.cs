using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPortal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        print("Portal Collided");
        if(other.tag == "Player"){
            PlayerColor playerColor = other.GetComponent<PlayerColor>();
            playerColor.setYellow();
        }
    }
}
