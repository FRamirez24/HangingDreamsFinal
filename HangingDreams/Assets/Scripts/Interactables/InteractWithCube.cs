using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithCube : MonoBehaviour, IInteractable

{
    public GameObject readingScreen;
    // Start is called before the first frame update
    public void Interact()
    {
        Debug.Log("it work");
    }
    private void Start()
    {
        readingScreen.SetActive(false);
    }
}
