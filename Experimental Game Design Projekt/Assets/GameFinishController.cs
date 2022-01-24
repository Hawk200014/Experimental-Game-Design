using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinishController : MonoBehaviour
{



    public void toMainMenu(){
        SceneManager.LoadScene("Menu");
    }

}
