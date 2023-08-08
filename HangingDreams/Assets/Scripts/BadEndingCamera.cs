using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEndingCamera : MonoBehaviour
{
    public AudioSource Listener;
    public AudioClip chairFalling;
    // Start is called before the first frame update
    void Start()
    {
        Listener.PlayOneShot(chairFalling, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
