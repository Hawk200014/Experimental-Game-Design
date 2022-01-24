using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipWobble : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float uperborder;
    [SerializeField] float lowerborder;
    bool down;
    bool up;

    Vector3 lowervector;
    Vector3 upervector;

    void Start(){
        up = true;
        down = false;
        lowervector = new Vector3(this.transform.position.x, this.transform.position.y-lowerborder, this.transform.position.z);
        upervector = new Vector3(this.transform.position.x, this.transform.position.y+uperborder, this.transform.position.z);
    }


    // Update is called once per frame
    void Update()
    {
        if(up){
            this.transform.position = Vector3.MoveTowards(this.transform.position, upervector, Time.deltaTime*speed);
            if(Mathf.Abs( upervector.y - transform.position.y)  < 0.001 ){
                up = false;
                down = true;
            }
        }
        else if(down){
            this.transform.position = Vector3.MoveTowards(this.transform.position, lowervector, Time.deltaTime*speed);
            if(Mathf.Abs(transform.position.y - lowervector.y) < 0.001){
                up = true;
                down = false;
            }
        }



    }
}
