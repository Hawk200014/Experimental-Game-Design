using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActiv : MonoBehaviour
{
    [SerializeField] bool isActive;
    void Start()
    {
        isActive = true;
    }


    public bool getActive(){
        return isActive;
    }

    public void setInactive(){
        isActive = false;
        this.GetComponent<PlayerMovementScript>().enabled= false;
        this.GetComponent<PlayerDie>().enabled = false;
        this.GetComponents<CircleCollider2D>()[1].enabled = true;
        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }



}
