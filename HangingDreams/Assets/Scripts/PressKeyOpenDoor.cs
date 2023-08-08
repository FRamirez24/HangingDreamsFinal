using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PressKeyOpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObjectOpen;
    public GameObject ThisTrigger;
    public AudioSource DoorOpenSound;
    public bool Action = false;
    public bool Open = false;
    public GameObject AnimeObjectClose;

    void Start()
    {
        Instruction.SetActive(false);
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
            if (Action == true && Open == false)
            {
                Instruction.SetActive(false);
                AnimeObjectOpen.GetComponent<Animator>().Play("DoorOpen");
               
                Open = true;
                //DoorOpenSound.Play();
            } 
        }

    }
}
