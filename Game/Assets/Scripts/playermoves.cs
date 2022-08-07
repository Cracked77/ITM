using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermoves : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask Groundmask;
    bool isgrounded;

    private int count;
    public Text countertext;
    public Text wintext;

    void setcountertext()
    {
        countertext.text = count.ToString() + "/4";
        if (count >= 4)
        {
            wintext.text = "Guess you win this time"; 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setcountertext();
        wintext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundCheck.position, GroundDistance, Groundmask);
        if (isgrounded && velocity.y < 00)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
    controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Door")
        {
            if(other.GetComponent<WorkingDoor>().Moving == false)
            {
                other.GetComponent<WorkingDoor>().Moving = true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setcountertext();


        }
       

    }
}
