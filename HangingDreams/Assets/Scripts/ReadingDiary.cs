using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingDiary : MonoBehaviour
{

    public GameObject[] Pages;

    public GameObject Diary;

    int i;

    // Start is called before the first frame update
    void Start()
    {

        //Diary.SetActive(false);

        i = 0;

    }

    public void NextPage()
    {

        if (i < 5)
        {

            Pages[0 + i].SetActive(false);

            i++;

            Pages[0 + i].SetActive(true);

        }

    }

    public void PreviousPage()
    {

        if (i > 0)
        {

            Pages[0 + i].SetActive(false);

            i--;

            Pages[0 - i].SetActive(true);

        }

    }


}
