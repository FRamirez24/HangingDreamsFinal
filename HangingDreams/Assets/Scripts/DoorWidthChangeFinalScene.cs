using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class DoorWidthChangeFinalScene : MonoBehaviour
{
    public bool openDoorFully = false;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoorFully == true)
        {
            transform.localScale += new Vector3(speed * Time.deltaTime, 0, 0.0025f * Time.deltaTime);
            float scaleX = transform.localScale.x;
            if (scaleX > 1.68f)
            {
                openDoorFully = false;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        loadlevel("GoodEnding");
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }
}
