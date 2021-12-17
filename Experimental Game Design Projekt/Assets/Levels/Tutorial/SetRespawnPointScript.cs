using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawnPointScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] PlayereController PlayereController;
    [SerializeField] GameObject Respawn;

    void OnTriggerEnter2D(Collider2D collider2D){
        if(collider2D.tag != "Player") return;
        PlayereController.setRespawnPoint(Respawn);
        Destroy(this.gameObject, 1f);
    }
}
