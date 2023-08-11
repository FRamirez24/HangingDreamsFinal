using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    public int x = 0;
    Renderer rend;
    public float timeDelay = 0f;
    public AudioClip SwitchPage;
    public AudioClip KnockonDoor;
    public AudioClip MonsterShout;
    private AudioSource audioSource;
    public Page4Trigger p4;
    public PeepHoleCameraChange Phc;
    public GameObject monsterWarning;


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[x];
        rend.enabled = true;
        audioSource = GetComponent<AudioSource>();
        monsterWarning.SetActive(false);
        
        
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
            if (x == 17)
            {

                StartCoroutine(monsterScream());

                StartCoroutine(monsterText());

                StartCoroutine(monsterAttack());

                StartCoroutine(loopShout());

            }
            if (x == 20)
            {

                SceneManager.LoadScene(3);

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
        Phc.completed = true;

    }

    IEnumerator monsterScream()
    {
        yield return new WaitForSeconds(3);
        monsterWarning.SetActive(true);
        audioSource.PlayOneShot(MonsterShout);
    }

    IEnumerator monsterText()
    {

            yield return new WaitForSeconds(6);
            monsterWarning.SetActive(false);
        
    }

    IEnumerator monsterAttack()
    {
        
            yield return new WaitForSeconds(3);
            x++;
        
    }

    IEnumerator loopShout()
    {

        yield return new WaitForSeconds(6);
        for(int i = 0; i < 10; i++)
        {

            audioSource.PlayOneShot(MonsterShout);

        }

    }


    

}
