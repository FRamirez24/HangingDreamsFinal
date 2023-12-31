using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page4Trigger : MonoBehaviour
{
    public OpenBook book;
    public GameObject Instruction;
    public GameObject ThisTrigger;
    public AudioClip GrabPage;
    public bool Action = false;
    public MeshRenderer page4;
    public bool Page4Found = false;
    public bool pageReached = false;
    private AudioSource audioSource;



    void Start()
    {
        Instruction.SetActive(false);

        page4.enabled = false;

        Page4Found = false;

        audioSource = GetComponent<AudioSource>();

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
                Instruction.SetActive(false);
                audioSource.PlayOneShot(GrabPage);
                page4.enabled = false;
                Page4Found = true;
                book.canChangePage = true;

            }
        }
    }

    public void PageReached()
    {
        print("Hello");
        page4.enabled = true;

    }
}

    
    

