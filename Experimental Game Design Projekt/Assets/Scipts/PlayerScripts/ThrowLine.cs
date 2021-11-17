using System.Collections.Generic;
using UnityEngine;

public class ThrowLine : MonoBehaviour
{
private LineRenderer lr;
public int Points;


public GameObject Player;
private PlayerMovementScript movementScript;
private Rigidbody2D rigidbody2D;

private float collisionCheckRadius = 0.1f;

public float TimeOfSimulation;

private void Start()
{
    rigidbody2D = GetComponent<Rigidbody2D>();
    lr = GetComponent<LineRenderer>();
    Player = this.gameObject;
    movementScript = GetComponent<PlayerMovementScript>();
    lr = GetComponent<LineRenderer>();
    lr.startColor = Color.white;
}

// Update is called once per frame
void Update()
{
    if (movementScript.playerHitted)
    {
        lr.positionCount = SimulateArc().Count;

        for (int a = 0; a < lr.positionCount;a++)
        {
            lr.SetPosition(a, SimulateArc()[a]);
        }
    }
}

private List<Vector2> SimulateArc()
{
    float simulateForDuration = TimeOfSimulation;
    float simulationStep = 0.1f;//Will add a point every 0.1 secs.

    int steps = (int)(simulateForDuration / simulationStep);
    steps = 10;
    print("Steps: " + steps);
    List<Vector2> lineRendererPoints = new List<Vector2>();
    Vector2 calculatedPosition;
    Vector2 directionVector = movementScript.getForce(); // The direction it should go
    Vector2 launchPosition = transform.position;//Position where you launch from
    float launchSpeed = 5f;//The initial power applied on the player

    for (int i = 0; i < steps; ++i)
    {
        
        calculatedPosition = launchPosition + (directionVector * ( launchSpeed * i * simulationStep));
        //Calculate gravity
        print("Point " + i + ": " + calculatedPosition);
        calculatedPosition.y += rigidbody2D.gravityScale * (i * simulationStep);
        lineRendererPoints.Add(calculatedPosition);
        //if (CheckForCollision(calculatedPosition))//if you hit something
        //{
            //break;//stop adding positions
        //}

    }

    return lineRendererPoints;



}
private bool CheckForCollision(Vector2 position)
{
    Collider2D[] hits = Physics2D.OverlapCircleAll(position, collisionCheckRadius);
    if (hits.Length > 0)
    {
        for (int x = 0;x < hits.Length;x++)
        {
            if (hits[x].tag != "Player" && hits[x].tag != "Ground" && hits[x].tag != "Wall")
            {
                return true;
            }
        }

    }
    return false;
}


    public void showLine(){
        lr.enabled = true;
    }
    public void hideLines(){
        lr.enabled = false;
    }
}
