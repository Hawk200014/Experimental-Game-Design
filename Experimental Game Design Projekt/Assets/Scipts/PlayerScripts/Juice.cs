using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juice : MonoBehaviour
{
    private static int juicy = 0;
    [SerializeField][Range(0,2)] int JuiceOMeter;

    void Start(){
        juicy = JuiceOMeter;
    }

    public static int getJuice(){
        return juicy;
    }
    
}
