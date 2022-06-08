using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChaser : MonoBehaviour
{
    private NavMeshAgent monster;
    public GameObject FPS;
    public float RunRange = 4.0f;
    public float speed = 12f; 
 
    void Start()
    {
        monster = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, FPS.transform.position);

        if (distance < RunRange)
        {
            Vector3 disToPlayer = transform.position - FPS.transform.position;
            Vector3 newPosition = transform.position - disToPlayer;
            monster.SetDestination(newPosition);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
