using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFollow : MonoBehaviour
{
    [SerializeField] private GameObject ObjectToFollow;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;

    private Vector2 ObjectPos;
    //public TMP_Text text;
    public bool text_is_visible = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectPos = ObjectToFollow.transform.position;
        Vector2 text_pos = new Vector2(ObjectPos.x + offsetX, ObjectPos.y + offsetY);
        transform.position = text_pos;
    }
}
