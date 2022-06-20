using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject playerSphere;
    public GameObject cameraRef;
    Rigidbody rb;

    Vector3 cameraPosDif;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        cameraPosDif = -playerSphere.transform.forward;
        cameraPosDif.y = 2.0f;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateInput();
        UpdateCamera();
        UpdatePosition();
    }

    void UpdateCamera()
    {
        cameraRef.transform.position = transform.position - cameraPosDif * -1;
        cameraRef.transform.forward = transform.position - cameraRef.transform.position;
    }

    void UpdatePosition()
    {
        
        //transform.position = playerSphere.transform.position;
    }

    void UpdateInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
        }

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
        }
    }
}