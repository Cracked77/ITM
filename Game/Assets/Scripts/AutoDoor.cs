using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public GameObject movingDoor;
    bool PlayerIsHere;
    bool opening;
    public float maximumOpening = 10f;
    public float maximumClosing = 0f;

    void Start()
    {
        PlayerIsHere = false;
        opening = false;

    }
    void Update()
    {
        if (PlayerIsHere)
        {
            if (movingDoor.transform.position.x < maximumOpening)
            {
                movingDoor.transform.Translate(1f * Time.deltaTime, 0f, 0f);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerIsHere = true;
        }

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerIsHere = false;
        }
    }
}
