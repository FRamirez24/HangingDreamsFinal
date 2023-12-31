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
    public Move2 m2;
    public OpenBook book;
    public GameObject findPage;
    public SkinnedMeshRenderer Page;


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[x];
        rend.enabled = true;
        audioSource = GetComponent<AudioSource>();
        monsterWarning.SetActive(false);
        findPage.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        print(x);
        rend.sharedMaterial = material[x];
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Page.GetComponent<Renderer>().enabled = true;

            StartCoroutine(timer(timeDelay));
        }
    }


    public void NextColor()
    {

        print("x: " + x);
        if (x < 20)
        {
            if (x == 1)
            {

                print("page reached");
                findPage.SetActive(true);
                StartCoroutine(FindPageTimer());
                p4.PageReached();
                book.canChangePage = false;

                if (p4.Page4Found = true)
                {

                    x++;

                }
            }
            else if (x == 11)
            {

                StartCoroutine(momDead());

                book.canChangePage = false;

                if (Phc.Peeked = true)
                {

                    x++;

                }

            }
            else if (x == 16)
            {


                StartCoroutine(monsterScream());

                StartCoroutine(monsterText());

                StartCoroutine(loopShout());

                x++;


            }
            else 
            {
                x++;

            }
        }
        else
        {
            x = 20;
            book.canChangePage = false;

            SceneManager.LoadScene(3);

              
        }
    }
        IEnumerator timer(float timerthing)
        {
            yield return new WaitForSeconds(timerthing);
            audioSource.PlayOneShot(SwitchPage);
            NextColor();
        Page.GetComponent<Renderer>().enabled = false;

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
            m2.attack();
        }

        IEnumerator monsterText()
        {

            yield return new WaitForSeconds(6);
            monsterWarning.SetActive(false);

        }

    IEnumerator FindPageTimer()
    {

        yield return new WaitForSeconds(6);
        findPage.SetActive(false);

    }

    IEnumerator loopShout()
        {

            yield return new WaitForSeconds(6);
            for (int i = 0; i < 10; i++)
            {

                audioSource.PlayOneShot(MonsterShout);

            }

        }


    }
