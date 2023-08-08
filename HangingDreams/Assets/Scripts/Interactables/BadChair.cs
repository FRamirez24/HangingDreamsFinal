using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class BadChair : MonoBehaviour, IInteractable
{
    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }

    // Start is called before the first frame update
    public void Interact()
    {
        loadlevel("BadEnding");
    }

    // Update is called once per frame

}
