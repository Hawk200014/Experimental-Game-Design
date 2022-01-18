using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject respawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 respawn_coordinates = new Vector2(respawnpoint.transform.position.x, respawnpoint.transform.position.y);
        if (other.tag == "Player")
        {
            other.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            other.transform.position = respawn_coordinates;


        }
    }
}
