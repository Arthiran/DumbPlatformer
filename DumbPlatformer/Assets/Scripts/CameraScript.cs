using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private string direction;
    public Transform playerTransform;

    private float rotateSpeed = 2f;
    private float offsetY = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(playerTransform.position.x, playerTransform.position.y + offsetY, transform.position.z), 0.075f);
    }

    private void cameraRot(string _direction)
    {
        if (_direction == "left")
        {
            transform.Rotate(0, 0, -rotateSpeed);
        }
        else if (_direction == "right")
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
    }
}
