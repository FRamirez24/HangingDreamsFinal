using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingDiary : MonoBehaviour
{

    public GameObject[] Pages;

    public GameObject Diary;

    public int i;

    // Start is called before the first frame update
    void Start()
    {

        //Diary.SetActive(false);

        i = 0;

        Pages[i].SetActive(true);

    }

    public void NextPage()
    {

        if (i < Pages.Length)
        {

            Pages[i].SetActive(false);

            i++;

            Pages[i].SetActive(true);

        }

    }

    public void PreviousPage()
    {

    
       

            Pages[i].SetActive(false);

            i--;

            Pages[i - 1].SetActive(true);

        

    }


}
