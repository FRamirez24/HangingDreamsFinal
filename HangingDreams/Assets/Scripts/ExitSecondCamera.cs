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

        StartCoroutine(holdPlayer());

        

    }

    IEnumerator holdPlayer()
    {

            yield return new WaitForSeconds(4);


        if (Input.GetKeyDown(KeyCode.E))
        {

            cam2.SetActive(false);

            cam1.SetActive(true);

            Tint.SetActive(false);

        }
    }
}
