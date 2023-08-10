using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(WarningRead());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WarningRead()
    {


        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(2);



    }
}
