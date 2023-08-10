using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryRead : MonoBehaviour
{
   
    public GameObject Diary;

    public GameObject ThisTrigger;

    public bool Action = false;

    void Start()
    {

        Diary.SetActive(false);


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {

                Diary.SetActive(true);


            }
        }

    }
}
