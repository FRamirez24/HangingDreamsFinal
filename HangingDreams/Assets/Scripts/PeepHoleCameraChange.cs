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

    public GameObject Tint;

    //public Move TM;

    void Start()
    {
        //TM = GameObject.Find("Mimic").GetComponent<Move>();

        Instruction.SetActive(false);

        cam1.SetActive(true);

        cam2.SetActive(false);

        Tint.SetActive(false);

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
                ThisTrigger.SetActive(false);
                Action = false;
                cam1.SetActive(false);
                cam2.SetActive(true);
                Tint.SetActive(true);

                //TM.PeepHole = true;
                //TM.RunningRemaining = TM.RunningTime;
            }
        }

    }
}
