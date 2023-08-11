using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeepHoleCameraChange : MonoBehaviour
{

    public GameObject cam1;

    public GameObject cam2;

    public GameObject Instruction;

    public GameObject ThisTrigger;

    public bool Action = false;

    public Move TM;

    public bool completed = false;

    public bool Peeked = false;

    public OpenBook book;

    void Start()
    {
        TM = GameObject.Find("Mimic").GetComponent<Move>();

        Instruction.SetActive(false);

        cam1.SetActive(true);

        cam2.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player" && completed == true)
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
                ThisTrigger.SetActive(false);
                Action = false;
                cam1.SetActive(false);
                cam2.SetActive(true);
                Peeked = true;
                book.canChangePage = true;

                TM.PeepHole = true;
                TM.RunningRemaining = TM.RunningTime;
                TM.audioSource.PlayOneShot(TM.Jumpscare);
                TM.audioSource.PlayOneShot(TM.run);
            }
        }

    }
}
