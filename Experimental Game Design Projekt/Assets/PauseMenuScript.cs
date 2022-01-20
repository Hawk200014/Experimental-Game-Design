using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] GameObject pausemenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            pausemenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Continue(){
        pausemenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
