using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingDoor : MonoBehaviour
{
    public vector3 endPosition;
    public float speed = 1f;

    private bool move = false;
    private bool opening = true;
    private vector 3 startPosition;
    private float delay = 0f;



    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void moveDoor(Vector finalposition)
    {
        float dist = Vector3.Distance()
    }
}
