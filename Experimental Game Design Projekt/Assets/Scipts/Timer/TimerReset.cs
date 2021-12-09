using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CanvasFollowPlayer.stop = true;
            CanvasFollowPlayer.minutes = 0;
            CanvasFollowPlayer.seconds = 0;
        }
    }
}
