using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDescend : MonoBehaviour
{
    private bool alreadyenabled = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("YellowPortal").GetComponent<PortalFloat>().enabled = false;
        GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = false;
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        if(alreadyenabled == false)
        {
        if (GameObject.Find("Dialog Box") == null)
        {
            GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = true;
            alreadyenabled = true;
        }
        }

        if (GameObject.Find("DialogBoxShip") == null)
            GameObject.Find("Player").GetComponent<PlayerMovementScript>().enabled = true;

    }

    IEnumerator wait()
    {
        float ypos = transform.position.y;
        while (ypos > 0.091)
        {
            ypos = transform.position.y;

            transform.position = new Vector2(transform.position.x, transform.position.y - (float)0.03);
            yield return new WaitForSeconds(0.05f);
        }
        GameObject.Find("YellowPortal").GetComponent<PortalFloat>().enabled = true;
        
        
    }
}
