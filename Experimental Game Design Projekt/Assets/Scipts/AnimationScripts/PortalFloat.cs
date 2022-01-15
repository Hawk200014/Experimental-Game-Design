using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFloat : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    IEnumerator wait()
    {
        float time = 0.4f;
        while(true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (float)0.02);
            yield return new WaitForSeconds(time);
            transform.position = new Vector2(transform.position.x, transform.position.y + (float)0.02);
            yield return new WaitForSeconds(time);


            transform.position = new Vector2(transform.position.x, transform.position.y - (float)0.02);
            yield return new WaitForSeconds(time);
            transform.position = new Vector2(transform.position.x, transform.position.y - (float)0.02);
            yield return new WaitForSeconds(time);

        }
    }
}
