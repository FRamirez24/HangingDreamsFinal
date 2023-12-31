using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

interface IInteractable
{
    public void Interact();
}

public class Interact : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractorRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(ray, out RaycastHit hitInfor, InteractorRange))
            {
                print(hitInfor);
                if (hitInfor.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();

                }
            }
        }
    }
}
