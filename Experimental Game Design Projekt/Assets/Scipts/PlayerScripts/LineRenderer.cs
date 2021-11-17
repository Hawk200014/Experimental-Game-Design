using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer : MonoBehaviour
{
    private GameObject player;
    private LineRenderer lineRenderer;
    private PlayerMovementScript playerMovement;
    void Start()
    {
        player = this.gameObject;
        lineRenderer = player.GetComponent<LineRenderer>();
        playerMovement = player.GetComponent<PlayerMovementScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.getPlayerHit()){
            List<Vector3> pos = new List<Vector3>();
            pos.Add(playerMovement.getRelativMousePos());
            pos.Add(player.transform.position);
            
        }
    }
}
