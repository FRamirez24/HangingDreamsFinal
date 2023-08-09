using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBedCamera : MonoBehaviour
{
    public GameObject cam1;

    public GameObject cam2;

    public MeshRenderer player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            player.enabled = true;

            cam2.SetActive(false);

            cam1.SetActive(true);


        }

    }
}
