using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour, IInteractable
{
    public LookAround lookaroundscript;
    public PlayerMovement movePlayer;
    public GameObject readingScreen;
    // Start is called before the first frame update
    void Start()
    {
        readingScreen.SetActive(false);
    }

    public void Interact()
    {
        Debug.Log("it work");
        readingScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        lookaroundscript.doMoveCamera = false;
        movePlayer.doWalkAround = false;

    }
    void Update()
    {
        if(lookaroundscript.doMoveCamera == false && Input.GetButtonDown("Cancel"))
        {
            readingScreen.SetActive(false) ;
            lookaroundscript.doMoveCamera = true;
            Cursor.lockState = CursorLockMode.Locked;
            movePlayer.doWalkAround = true;
        }

    }
}
