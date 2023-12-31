using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public bool doWalkAround = true;

    private FootstepController footstepController;

    void Start()
    {

        footstepController = GetComponentInChildren<FootstepController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (doWalkAround == true)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * Time.deltaTime * speed);



            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                footstepController.StartWalking();
            }
            else
            {

                footstepController.StopWalking();

            }
        }

    }
}
        

        