using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedCameraChange : MonoBehaviour, IInteractable
{
    public GameObject cam1;

    public GameObject cam2;

    public MeshRenderer player;

    public GameObject instruction;

    public ExitBedCamera EBC;



    void Start()
    {
        EBC = GameObject.Find("play").GetComponent<ExitBedCamera>();

        cam1.SetActive(true);

        cam2.SetActive(false);

        player.enabled = true;

        instruction.SetActive(false);


    }

    public void Interact()
    {

        player.enabled = false;
        cam2.SetActive(true);
        cam1.SetActive(false);
        EBC.SoundPlayer2D.Play();

    }
}
