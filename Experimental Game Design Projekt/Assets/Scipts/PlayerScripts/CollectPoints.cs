using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour
{


    [SerializeField] PointControllerScript pointControllerScript;
    private int points;
    AudioSource audioSource;
    ParticleSystem particleSystem;
    void Start()
    {
        points = 0;
    }

    public void setPointController(PointControllerScript pointControllerScript){
        this.pointControllerScript = pointControllerScript;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Point"){
            audioSource = other.GetComponent<AudioSource>();
            print("Point");
            pointControllerScript.addOnePoint();
            points++;
            if(Juice.getJuice() == 0){
                Destroy(other.gameObject);
            }
            else if(Juice.getJuice() == 1){
                audioSource.Play();
                other.GetComponent<SpriteRenderer>().enabled = false;
                Destroy(other.gameObject, 3);
            }
            else if(Juice.getJuice() == 2){
                audioSource.Play();
                other.GetComponent<ParticleSystem>().Play();
                other.GetComponent<SpriteRenderer>().enabled = false;
                Destroy(other.gameObject, 0.5f);
            }
        }
    }
}
