using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MissileBehaviour : MonoBehaviour
{
    public float minSpeed = 500f;
    public float maxSpeed = 1000f;
    private float _maxHeight = 1200f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
        
        if (transform.position.y >= _maxHeight)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
