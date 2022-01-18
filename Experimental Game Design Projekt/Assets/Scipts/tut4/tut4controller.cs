using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut4controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("DialogBoxShip") == null)
        {
            GameObject.Find("schiff").GetComponent<YellowWallColliding>().enabled = true;
            GameObject.Find("schiff").GetComponent<CapsuleCollider2D>().enabled = true;
            GameObject.Find("schiff").GetComponent<SpriteRenderer>().color = new Color(253, 253, 0, 255);
            
        }
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.parent = transform;
            StartCoroutine(ascend());
        }
    }

    IEnumerator ascend()
    {
        while(true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (float)0.03);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
