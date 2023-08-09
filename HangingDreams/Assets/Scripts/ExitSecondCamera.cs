using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSecondCamera : MonoBehaviour
{
    public GameObject cam1;

    public GameObject cam2;

    public GameObject Tint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E))
        {

            StartCoroutine(holdPlayer());

        }

    }

    IEnumerator holdPlayer()
    {


            yield return new WaitForSeconds(3);

            cam2.SetActive(false);

            cam1.SetActive(true);

            Tint.SetActive(false);

        

    }
}
