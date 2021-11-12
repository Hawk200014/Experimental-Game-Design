using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMusicControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Juice.getJuice() > 0){
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
