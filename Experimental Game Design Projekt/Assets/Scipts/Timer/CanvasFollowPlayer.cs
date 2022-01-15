using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasFollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;

    private Vector2 playerPos;
    public static float minutes = 0;
    public static float seconds = 0;
    public TMP_Text text;
    public static bool stop = true;
    private GameObject PlayerController;
    private PlayereController playereControllerscript;

    public bool text_is_visible = true;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "test";
        this.PlayerController = GameObject.Find("PlayerCon");
        this.playereControllerscript = this.PlayerController.GetComponent<PlayereController>();
    }

    // Update is called once per frame
    void Update()
    {
        Player = this.playereControllerscript.getActivPlayer();

        if (minutes > 0 || seconds > 0)
        {
            if (stop == false)
                seconds -= 1 * Time.deltaTime;
            if (seconds < 10)
                text.text = minutes + ":0" + seconds.ToString("f2");
            else
                text.text = minutes + ":" + seconds.ToString("f2");

            if (seconds > 60)
            {
                seconds = seconds % 10;
                minutes += 1;
            }
            if (minutes > 0 && seconds < 0)
            {
                seconds = 60;
                minutes -= 1; 
            }
        }
        else
            text.text = "test";


        playerPos = Player.transform.position;
        Vector2 text_pos = new Vector2(playerPos.x + offsetX, playerPos.y + offsetY);
        transform.position = text_pos;



        

    }
}
