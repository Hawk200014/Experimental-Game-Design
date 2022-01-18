using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_move : MonoBehaviour
{
    [SerializeField] bool go_right = false;
    [SerializeField] float left;
    [SerializeField] float right;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xpos = transform.position.x;

        if (xpos >= right)
            go_right = !go_right;

        if (xpos <= left)
            go_right = !go_right;


        if (go_right)
        {
            Quaternion target = Quaternion.Euler(0, 180, 0);
            transform.rotation = target;
            transform.position = new Vector2(xpos + 1f * Time.deltaTime, transform.position.y);
        }
            
        else
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = target;
            transform.position = new Vector2(xpos - 1f * Time.deltaTime, transform.position.y);
            
        }
            
    }
}
