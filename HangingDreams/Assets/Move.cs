using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MimicSpace;

public class Move : MonoBehaviour
{
    [Header("Controls")]
    [Tooltip("Body Height from ground")]
    [Range(0.5f, 5f)]
    public float height = 0.8f;
    public float speed = 20f;
    Vector3 velocity = Vector3.zero;
    public float velocityLerpCoef = 4f;
    private Mimic myMimic;
    public bool PeepHole = false;
    public float RunningTime = 0.75f;
    public float RunningRemaining = 0;


    private void Start()
    {
        myMimic = GetComponent<Mimic>();
    }

    void Update()
    {
        //velocity = Vector3.Lerp(velocity, new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * speed, velocityLerpCoef * Time.deltaTime);

        // Assigning velocity to the mimic to assure great leg placement
        myMimic.velocity = velocity;

        transform.position = transform.position + velocity * Time.deltaTime;
        RaycastHit hit;
        Vector3 destHeight = transform.position;
        if (Physics.Raycast(transform.position + Vector3.up * 5f, -Vector3.up, out hit))
            destHeight = new Vector3(transform.position.x, hit.point.y + height, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, destHeight, velocityLerpCoef * Time.deltaTime);
       if (PeepHole == true && RunningRemaining > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            RunningRemaining -= Time.deltaTime;

        }


    }
}
