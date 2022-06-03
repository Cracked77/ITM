using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingDoor : MonoBehaviour
{
    public Vector3 endPosition;
    public float speed = 1f;

    private bool move = false;
    private bool opening = true;
    private Vector3 startPosition;
    private float delay = 0f;



    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
       if(move)
        {
            if (opening)
            {
                moveDoor(endPosition);
            }
            else
            {
                moveDoor(startPosition);
            }
        }

    }
    void moveDoor(Vector3 finalposition)
    {
        float dist = Vector3.Distance(transform.position, finalposition);
        if(dist > 1f)
        {
            transform.position = Vector3.Lerp(transform.position, finalposition, speed * Time.deltaTime);
        }
        else
        {
            if (opening)
            {
                delay += Time.deltaTime;
                if(delay > 1.5f)
                {
                    opening = false;
                }
                else
                {
                    move = false;
                    opening = true;
                }
            }
        }
    }
    public bool Moving
    {
        get { return move; }
        set { move = value; }
    }
}
