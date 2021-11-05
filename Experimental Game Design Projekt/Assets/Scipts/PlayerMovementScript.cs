using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] float movespeed = 100f;
    [SerializeField] float veloX;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.veloX = rigidbody2D.velocity.x;

        if(Input.GetKey(KeyCode.D)){
            rigidbody2D.AddForce(new Vector2(movespeed*Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.A)){
            rigidbody2D.AddForce(new Vector2(-movespeed*Time.deltaTime,0));
        }
        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)){
            if(rigidbody2D.velocity.x < 0)
                rigidbody2D.AddForce(new Vector2(- rigidbody2D.velocity.x * 0.5f , 0));
            else if(rigidbody2D.velocity.x > 0)
                rigidbody2D.AddForce(new Vector2(- rigidbody2D.velocity.x * 0.5f, 0));
        }
    }
}
