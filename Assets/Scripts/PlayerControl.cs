using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Variables
    private Rigidbody playerRb; //initalise player rigid body
    public float speed = 5.0f; //initalise speed
    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); //get componant 
        focalPoint = GameObject.Find("FocalPoint"); 
    }

    // Update is called once per frame
    void Update()
    {
        //Moving forward with vertical axis
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
