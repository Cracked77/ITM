using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSense : MonoBehaviour
{
    [SerializeField]
    private TurningDoor Door;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<CharacterController>(out CharacterController controller))
        {
            if (!Door.IsOpen)
            {
                Door.open(other.transform.position);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<CharacterController>(out CharacterController controller))
        {
            if (Door.IsOpen)
            {
                Door.Close();
            }
        }
    }
}
