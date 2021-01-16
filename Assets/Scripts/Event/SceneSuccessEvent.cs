using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSuccessEvent : MonoBehaviour
{
    public Text label;
    public Text stopwatchLabel;
    private Stopwatch _stopwatch;
    
    // Start is called before the first frame update
    void Start()
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();
        label.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            label.text = "Cargo Delivered!";
            label.enabled = true;
            _stopwatch.Stop();
        }
    }

    private void FixedUpdate()
    {
        stopwatchLabel.text = (_stopwatch.ElapsedMilliseconds / 1000).ToString();
    }
}
