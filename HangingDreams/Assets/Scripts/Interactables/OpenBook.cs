using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpenBook : MonoBehaviour, IInteractable
{
    public LookAround lookaroundscript;
    public PlayerMovement movePlayer;
    public GameObject readingScreen;
    public Transform cam;
    public float offset = 3f;
    public Animator anim;
    public bool isInBook = false;
    private Vector3 oldPosition;
    private Quaternion oldRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Interact()
    {
        Vector3 oldPosition = cam.position;
        print(oldPosition);
        Quaternion oldRotation = cam.rotation;
        print(oldRotation);
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);

        cam.position = newPosition;
        cam.rotation = Quaternion.Euler(90f, transform.rotation.y, transform.rotation.z);

        lookaroundscript.doMoveCamera = false;

        movePlayer.doWalkAround = false;
        isInBook = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if(isInBook == true && Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("FlipPage");
            print("kill me");
            
        }

        if(isInBook == true && Input.GetButtonDown("Cancel"))
        {
            readingScreen.SetActive(false) ;
            lookaroundscript.doMoveCamera = true;
            Cursor.lockState = CursorLockMode.Locked;
            movePlayer.doWalkAround = true;
            isInBook = false;
            cam.position = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z);
            cam.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }

    }
}
