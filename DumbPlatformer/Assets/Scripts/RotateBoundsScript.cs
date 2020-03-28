using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoundsScript : MonoBehaviour
{
    public Vector3 rotSpeed;
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(rotSpeed);
    }
}
