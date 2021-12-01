using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] public int minutes;
    [SerializeField] public int seconds;


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
            CanvasFollowPlayer.minutes += minutes;
            CanvasFollowPlayer.seconds += seconds;
        }
    }
}
