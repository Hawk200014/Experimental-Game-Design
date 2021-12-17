using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialKlettCollider : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] TutorialController tutorialController;

    void OnTriggerEnter2D(Collider2D collider2D){
        if(collider2D.tag != "Player") return;
        tutorialController.KlettToClone();
    }
}
