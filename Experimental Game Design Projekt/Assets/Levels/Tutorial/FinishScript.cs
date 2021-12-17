using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    [SerializeField] GameObject FinishMenu;
    [SerializeField] Text text;
    [SerializeField] PointControllerScript pointControllerScript;


    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag != "Player") return;
        text.text = "Score: " + pointControllerScript.getCurrentPoints() + "/" + pointControllerScript.getMaxPoints();
        FinishMenu.SetActive(true);
        //disableMovement;
    }


    public void LoadLevel(){

    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
    }

}
