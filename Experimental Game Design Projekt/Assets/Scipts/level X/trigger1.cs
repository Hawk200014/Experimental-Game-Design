using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{
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
        if (other.tag == "Player")
        {
            Destroy(GameObject.Find("trigger2"));
            GameObject.Find("DialogBoxShip").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("SpaceShipText").GetComponent<TextScroll>().enabled = true;
            GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = false;
        }

    }
}
