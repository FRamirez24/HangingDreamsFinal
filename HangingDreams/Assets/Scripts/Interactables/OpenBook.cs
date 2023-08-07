using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour, IInteractable
{
    public GameObject readingScreen;
    // Start is called before the first frame update
    void Start()
    {
        readingScreen.SetActive(false);
    }

    public void Interact()
    {
        Debug.Log("it work");
        readingScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
