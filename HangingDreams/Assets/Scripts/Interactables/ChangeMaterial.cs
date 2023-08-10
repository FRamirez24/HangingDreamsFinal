using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] material;
    public int x;
    Renderer rend;
    public float timeDelay = 0f;


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[x];
        rend.enabled = true;
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

            x++;
        }

        else
        {
            x = 20;

        }
    }
    IEnumerator timer(float timerthing)
    {
        yield return new WaitForSeconds(timerthing);
        NextColor();
    }

}
