using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("tut1");
    }

    public void PlayPlayGround(){
        SceneManager.LoadScene("PlayGroundSpawn");
    }

    public void QuitGame(){
        Application.Quit();
    }

}
