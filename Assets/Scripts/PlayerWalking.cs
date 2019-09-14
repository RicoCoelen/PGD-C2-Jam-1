using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    public float speed = 0.1f;
    Vector3 velocity;
    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector3.zero;
        
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) {

            if (Input.GetKey("w"))
            {
                velocity.z += 1;
            }
            if (Input.GetKey("a"))
            {
                velocity.x -= 1;
            }
            if (Input.GetKey("s"))
            {
                velocity.z -= 1;
            }
            if (Input.GetKey("d"))
            {
                velocity.x += 1;
            }
        }
        velocity.Normalize();
        
        velocity = Quaternion.AngleAxis(transform.GetChild(0).rotation.eulerAngles.y, Vector3.up) * velocity;

        velocity *= speed;
        transform.Translate(velocity);
    }
}
