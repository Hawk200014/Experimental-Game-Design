using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform playerTransform;


    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
