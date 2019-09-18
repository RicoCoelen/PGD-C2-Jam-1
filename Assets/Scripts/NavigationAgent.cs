using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationAgent : MonoBehaviour
{
    // create array for points for alien to follow
    public static int aantalPoints = 0;
    public GameObject[] waypointGameObjects = new GameObject[aantalPoints];
    public float waypointRange = 1;
    int waypointCounter = 0;

    public Transform player;
    NavMeshAgent agent;
    bool Playerseen;



    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        Playerseen = GetComponent<PlayerSeen>().enemyDetected;

        Debug.Log(Playerseen);

        if (Playerseen == true)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            float distance = Vector3.Distance(waypointGameObjects[waypointCounter].transform.position, this.transform.position);

            if (waypointRange > distance)
            {
                waypointCounter++;
            }

            if (waypointCounter >= waypointGameObjects.Length)
            {
                waypointCounter = 0;
            }

            // move alien to waypoints
            agent.SetDestination(waypointGameObjects[waypointCounter].transform.position);
            
            // alien rotate view
            transform.rotation.SetLookRotation(this.GetComponent<Rigidbody>().velocity);
        }
    } 
}
