using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    public int x = 0;
    Renderer rend;
    public float timeDelay = 0f;
    public AudioClip SwitchPage;
    public AudioClip KnockonDoor;
    private AudioSource audioSource;
    public Page4Trigger p4;
    public PeepHoleCameraChange Phc;


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[x];
        rend.enabled = true;
        audioSource = GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        print(x);
        rend.sharedMaterial = material[x];
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(timer(timeDelay));
        }
    }


    public void NextColor()
    {
        
        print("work lol");
        if (x < 20)
        {
            if (x == 12)
            {

                StartCoroutine(momDead());

                if (Phc.Peeked = true)
                {

                    x++;

                }

            }
            else {

                x++;
            }
        }

        else
        {
            x = 20;

        }
    }
    IEnumerator timer(float timerthing)
    {
        yield return new WaitForSeconds(timerthing);
        audioSource.PlayOneShot(SwitchPage);
        NextColor();
    }

    IEnumerator momDead()
    {
        yield return new WaitForSeconds(3);
        audioSource.PlayOneShot(KnockonDoor);
    }


    //if (x == 2)
           // {

               // p4.pageReached();

               // if (p4.Page4Found = true)
               // {

                 //   x++;

               // }

           // }else

}
