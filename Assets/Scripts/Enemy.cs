using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables
    Rigidbody enemyRb;
    GameObject player;
    public float speed = 3;      

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the vector/look direction
        Vector3 lookDirection = (player.transform.position //player position - enemy position
            - transform.position);

        //Apply force in direction of the player
        enemyRb.AddForce(lookDirection.normalized * speed);
    }
}
