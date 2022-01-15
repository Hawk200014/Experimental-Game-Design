using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScroll : MonoBehaviour
{
    public GameObject[] DestroyOnEnd;
    public TMP_Text textObject;
    public string lines;
    public float textSpeed;
    bool skip = false;
    // Start is called before the first frame update
    void Start()
    {
        lines = lines.Replace(";", "\n");
        Debug.Log(lines);
        textObject.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < DestroyOnEnd.Length; i++)
            {
                Destroy(DestroyOnEnd[i]);
            }
            textObject.text = "";
            skip = true;
        }

          
    }

    IEnumerator TypeLine()
    { 
      foreach (char c in lines.ToCharArray())
        {
            if (c == '#')
            {
                yield return new WaitForSeconds(0.5f);
                textObject.text = "";
            }
            else
            {
              if(skip == false)
                {
                    textObject.text += c;
                }
                    
              yield return new WaitForSeconds(textSpeed);
            }
        }
        for(int i = 0; i < DestroyOnEnd.Length; i++)
        {
            Destroy(DestroyOnEnd[i]);
        }
        
    }

}
