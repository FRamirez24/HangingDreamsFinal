using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorOpensFinalScene : MonoBehaviour
{
    public bool openDoorFully = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoorFully == true)
        {
            transform.Rotate( 0, 0, Time.deltaTime * -10);
            float rotation = transform.rotation.z;
            print(rotation);
            if (rotation < -0.6)
            {
                openDoorFully = false;
            }
        }
    }
}
