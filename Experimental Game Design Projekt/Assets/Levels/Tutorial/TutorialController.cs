using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    private bool MovementTutorial = true;
    private bool JumpOverWalls = false;
    private bool PortalTutorial = false;
    private bool KlettTutorial = false;
    private bool CloneTutorial = false;

    [SerializeField] PlayereController playereController;
    

    [SerializeField] GameObject MovementTutorialObject;
    [SerializeField] GameObject JumpOverWallsObject;
    [SerializeField] GameObject PortalObject;
    [SerializeField] GameObject KlettObject;
    [SerializeField] GameObject CloneObject;


    // Update is called once per frame
    void Update()
    {
        if(MovementTutorial && playereController.getActivPlayer().GetComponent<Rigidbody2D>().velocity.x > 0){
            MovementTutorial = false;
            JumpOverWalls = true;
            JumpOverWallsObject.SetActive(true);
            MovementTutorialObject.SetActive(false);
        }

    }


    public void KlettToClone(){
        KlettObject.SetActive(false);
        KlettTutorial = false;
        CloneTutorial = true;
        CloneObject.SetActive(true);
    }

    public void PortalToKlett(){
        PortalTutorial = false;
        PortalObject.SetActive(false);
        KlettObject.SetActive(true);
        KlettTutorial = true;
    }

    public void JumpToPortal(){
        JumpOverWalls = false;
        PortalTutorial = true;
        JumpOverWallsObject.SetActive(false);
        PortalObject.SetActive(true);
    }

    

}
