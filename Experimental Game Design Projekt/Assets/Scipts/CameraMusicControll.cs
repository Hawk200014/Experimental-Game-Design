using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMusicControll : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private bool musicPlaying = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if(Juice.getJuice() == 1 || Juice.getJuice() == 2){
            if(!musicPlaying){
                print("Background Music");
                audioSource.loop = true;
                audioSource.Play();
                musicPlaying = true;
            }
        }
    }
}
