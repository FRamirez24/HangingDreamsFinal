using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCloset : MonoBehaviour
{
    public GameObject cam1;

    public GameObject cam2;

    public MeshRenderer player;

    public AudioSource SoundPlayer2D;

    public AudioClip sound;

    private AudioSource audioSource;

    
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        cam2.SetActive(false);

        audioSource = GetComponent<AudioSource>();

        SoundPlayer2D.clip = sound;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            player.enabled = true;

            cam2.SetActive(false);

            cam1.SetActive(true);

            SoundPlayer2D.Stop();

        }

    }
}
