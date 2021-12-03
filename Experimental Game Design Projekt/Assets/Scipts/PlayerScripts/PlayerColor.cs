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

    private PlayerActiv playerActiv;

    private AudioSource klettsound;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(1f,1f,1f,1f);
        playerActiv = GetComponent<PlayerActiv>();
        klettsound = GetComponents<AudioSource>()[1];
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

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            if(this.playerActiv.getActive()) return;
            if(other.gameObject.GetComponent<PlayerColor>().getColor() == this.getColor()){
                stickToIt(other);
            }
        }
    }

    private void stickToIt(Collider2D other){
        Rigidbody2D rigidbody2D = other.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0f,0f);
        rigidbody2D.gravityScale = 0; 
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            if(Juice.getJuice() < 1) return;
            if(this.playerActiv.getActive()) return;
            if(other.gameObject.GetComponent<PlayerColor>().getColor() == this.getColor()){
                klettsound.enabled = true;
                klettsound.Play();
            }
        }
    }

}
