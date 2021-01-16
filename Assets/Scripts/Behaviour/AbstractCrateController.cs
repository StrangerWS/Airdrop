using System;
using System.Collections;
using System.Collections.Generic;
using Schema;
using UnityEngine;

public class AbstractCrateController : MonoBehaviour
{
    private Vector3 _anchorPosition;
    
    public Transform anchor;
    public int bounds = 15;
    public float movementSpeed = 5.0f;

    public ControllerSchema ControllerSchema;
    // Start is called before the first frame update
    void Start()
    {
        _anchorPosition = anchor.position;
    }

    // Update is called once per frame
    void Update()
    {
        var xMovement = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        
        transform.Translate(new Vector3(xMovement, 0, 0));
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, _anchorPosition.x - bounds, _anchorPosition.x + bounds);
        position.z = Mathf.Clamp(position.z, _anchorPosition.z - bounds, _anchorPosition.z + bounds);

        transform.position = position;
    }
}
