using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("DialogBoxShip") == null)
            GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(GameObject.Find("trigger1"));
            GameObject.Find("DialogBoxShip").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("SpaceShipText").GetComponent<TextScroll>().enabled = true;
            GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = false;
        }
    }
}
