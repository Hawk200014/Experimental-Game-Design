using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    /*
        Spieler Farben:
            Y = Yellow
            B = Blue
            G = Green
            R = Red
            W = White

    */


    [SerializeField] char color;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(1f,1f,1f,1f);
    }

    public char getColor(){
        return color;
    }

    public void setGreen(){
        spriteRenderer.color = new Color(0f,1f,0f,1f);
        this.color = 'G';
    }

    public void setYellow(){
        spriteRenderer.color = new Color(1f,1f,0f,1f);
        this.color = 'Y';
    }

    public void setBlue(){
        spriteRenderer.color = new Color(0f,0f,1f,1f);
        this.color = 'B';
    } 

    public void setRed(){
        spriteRenderer.color = new Color(1f,0f,0f,1f);
        this.color = 'R';
    }

    public void setWhite(){
        spriteRenderer.color = new Color(1f,1f,1f,1f);
        this.color = 'W';
    }

}
