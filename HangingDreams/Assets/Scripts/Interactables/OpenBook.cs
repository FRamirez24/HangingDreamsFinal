using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpenBook : MonoBehaviour, IInteractable
{
    public LookAround lookaroundscript;
    public PlayerMovement movePlayer;
    public Transform cam;
    public float offset = 3f;
    public Animator anim;
    public bool isInBook = false;
    private Vector3 oldPosition;
    private Quaternion oldRotation;
    public bool canChangePage = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Interact()
    {
        Vector3 oldPosition = cam.localPosition;
        print(oldPosition);
        Quaternion oldRotation = cam.rotation;
        print(oldRotation);
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);

        cam.position = newPosition;
        cam.rotation = Quaternion.Euler(80.926f, -7.68f, 0);

        lookaroundscript.doMoveCamera = false;

        movePlayer.doWalkAround = false;
        isInBook = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if(isInBook == true && Input.GetKeyDown(KeyCode.RightArrow) && canChangePage == true)
        {
            anim.SetTrigger("FlipPage");
            print("kill me");
            
        }

        if(isInBook == true && Input.GetButtonDown("Cancel"))
        {
            lookaroundscript.doMoveCamera = true;
            Cursor.lockState = CursorLockMode.Locked;
            movePlayer.doWalkAround = true;
            isInBook = false;
            cam.localPosition = new Vector3(0, 0.718f, 0);
            cam.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }

    }

    public IEnumerator flipPageTimer(float time)
    {
        yield return new WaitForSeconds(time);
        canChangePage = true;
    }
}
