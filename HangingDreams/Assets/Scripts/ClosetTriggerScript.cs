using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetTriggerScript : MonoBehaviour
{
    public GameObject cam1;

    public GameObject cam2;

    public MeshRenderer player;

    public GameObject instruction;

    public ExitCloset EC;

    public bool play = false;

    public GameObject Instruction;

    public GameObject ThisTrigger;

    public bool Action = false;

    public bool Open = false;



    void Start()
    {
        EC = GameObject.Find("play").GetComponent<ExitCloset>();

        Instruction.SetActive(false);

        cam1.SetActive(true);

        cam2.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                player.enabled = false;
                cam2.SetActive(true);
                cam1.SetActive(false);
                EC.SoundPlayer2D.Play();

            }
        }

    }
}
