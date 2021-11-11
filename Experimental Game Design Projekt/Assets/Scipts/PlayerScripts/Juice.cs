using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juice : MonoBehaviour
{
    private static int juicy = 0;
    [SerializeField][Range(0,2)] int juicyHelper;

    void Start(){
        juicy = juicyHelper;
    }

    public static int getJuice(){
        return juicy;
    }
    
}
