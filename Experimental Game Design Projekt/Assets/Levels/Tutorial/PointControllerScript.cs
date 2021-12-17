using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControllerScript : MonoBehaviour
{

    [SerializeField] int MaxPoints;
    private int currentPoints;
    // Start is called before the first frame update
    void Start()
    {
        currentPoints = 0;
    }

    public void setMaxPoints(int maxpoints){
        MaxPoints = maxpoints;
    }

    public int getMaxPoints(){
        return MaxPoints;
    }

    public void addOnePoint(){
        currentPoints++;
    }

    public int getCurrentPoints(){
        return currentPoints;
    }
}
