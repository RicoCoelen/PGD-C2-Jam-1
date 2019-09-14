using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float sensitivity = 100f;
    Quaternion originalRotation;
    private float Ymovement = 0;
    private float Xmovement = 0;


    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = originalRotation;

        Xmovement -= Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;
        Ymovement += Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;

        transform.Rotate(Xmovement, Ymovement, 0);
    }
}
