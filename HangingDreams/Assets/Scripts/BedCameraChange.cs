using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedCameraChange : MonoBehaviour, IInteractable
{
    public GameObject cam1;

    public GameObject cam2;

    public MeshRenderer player;


    void Start()
    {
        
        cam1.SetActive(true);

        cam2.SetActive(false);

        player.enabled = true;


    }

    public void Interact()
    {
        print("lol");
        player.enabled = false;
        cam2.SetActive(true);
        cam1.SetActive(false);
    }
}
