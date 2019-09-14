using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeen : MonoBehaviour
{
    RaycastHit hit;
    Vector3 rayDirection;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        rayDirection = player.transform.position - transform.position;
        Debug.Log(rayDirection);
        if (Physics.Raycast(transform.position, rayDirection, out hit, rayDirection.magnitude))
        {
            if (hit.collider.tag == "Player")
            {
                Debug.Log("OKE");
            }
        }
    }
}
