using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehaviour : MonoBehaviour
{
    public Transform objectToFollow;
    
    private float _minHeight = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       DescendCameraAfterObject();
       if (transform.position.y <= _minHeight)
       {
           transform.LookAt(objectToFollow);
       }
    }



    private void DescendCameraAfterObject()
    {
        {
            transform.position = new Vector3(
                transform.position.x,
                Mathf.Clamp(objectToFollow.position.y + 5, _minHeight, 2000),
                transform.position.z);
        }
    }
}
