using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Transform cameraTransform;
    private Rigidbody rb;

    private string direction;
    private float gravity = -9.8f;
    private float rotateSpeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = "left";
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = "right";
        }
        else
        {
            direction = "null";
        }
    }

    private void FixedUpdate()
    {
        cameraRot(direction);
        rb.velocity = cameraTransform.up * gravity;
    }

    private void cameraRot(string _direction)
    {
        if (_direction == "left")
        {
            cameraTransform.Rotate(0, 0, -rotateSpeed);
        }
        else if (_direction == "right")
        {
            cameraTransform.Rotate(0, 0, rotateSpeed);
        }
    }
}
