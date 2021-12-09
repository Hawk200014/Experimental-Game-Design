using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        print("TriggerHit");
        print(this.tag);
        if(this.tag == "RestartLevelButton"){

            if(other.tag == "Player"){
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}
