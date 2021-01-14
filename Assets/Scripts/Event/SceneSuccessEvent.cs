using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSuccessEvent : MonoBehaviour
{
    public Transform target;
    
    public Text label;
    // Start is called before the first frame update
    void Start()
    {
        label.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            label.text = "Cargo Delivered!";
            label.enabled = true;
        }
    }
}
