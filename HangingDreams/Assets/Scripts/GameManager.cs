using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerMovement movement;
    public LookAround mainCamera;
    public bool moveableCharacter = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public bool lockCharacter(bool outcome)
    {
        moveableCharacter = outcome;
        return moveableCharacter;
    }
}
