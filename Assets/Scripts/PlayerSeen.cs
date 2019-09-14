using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeen : MonoBehaviour
{
    RaycastHit hit;
    Vector3 rayDirection;
    GameObject player;
    public float FOV = 90;
    float angle;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if an object is blocking the view of the alien
        rayDirection = player.transform.position - transform.position;
        if (Physics.Raycast(transform.position, rayDirection, out hit, rayDirection.magnitude))
        {
            if (hit.collider.tag == "Player")
            {
                //Checks if the player is in the FOV
                angle = Vector3.Angle(rayDirection, Vector3.forward);
                if(angle < FOV / 2)
                    Debug.Log("Player detected");
            }
        }
    }
}
