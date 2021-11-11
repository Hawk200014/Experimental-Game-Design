using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Start is called before the first frame update

    private bool doorclose = true;
    private bool doordown = false;
    private AudioSource audioSource;

    [SerializeField] ParticleSystem particleSystem;

    [SerializeField] float initY;
    void Start(){
        initY = this.transform.position.y;
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        if(doordown){
            if(this.transform.position.y < initY+2f){
                this.transform.position= new Vector3(this.transform.position.x ,this.transform.position.y+0.001f, this.transform.position.z);
            }
            else{
                audioSource.Stop();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        print("Button Press");
        if(other.tag == "Player" && doorclose){
            doorclose = false;
            if(Juice.getJuice() == 0){
                Destroy(this.gameObject);
            }
            else if(Juice.getJuice() == 1){
                doordown = true;
                audioSource.Play();
            }
            else if(Juice.getJuice() == 2){
                doordown = true;
                audioSource.Play();
                particleSystem.Play();
                Destroy(particleSystem.gameObject, 3);
            }
        }
    }

}
