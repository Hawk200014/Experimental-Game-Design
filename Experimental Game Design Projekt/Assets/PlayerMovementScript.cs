using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] float movespeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = Vector2.zero;

        if(Input.GetKey(KeyCode.S)){
            rigidbody2D.velocity = new Vector2(0, -movespeed  * Time.deltaTime);
        }   
        if(Input.GetKey(KeyCode.D)){
            rigidbody2D.velocity = new Vector2(movespeed*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.W)){
            rigidbody2D.velocity = new Vector2(0, movespeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            rigidbody2D.velocity = new Vector2(-movespeed*Time.deltaTime,0);
        }
    }
}
