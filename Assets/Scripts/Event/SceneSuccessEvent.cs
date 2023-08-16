using System.Diagnostics;
using Consts;
using UnityEngine;
using UnityEngine.UI;

namespace Event
{
    public class SceneSuccessEvent : MonoBehaviour
    {
        public GameState gameState;
        
        public Text label;
        public Text stopwatchLabel;
        private Stopwatch _stopwatch;
    
        // Start is called before the first frame update
        void Start()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
            gameState.State = State.Playing;
            label.enabled = false;
        }

        // Update is called once per frame
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                label.text = "Cargo Delivered!";
                label.enabled = true;
                _stopwatch.Stop();
                gameState.State = State.Won;
            }
        }

        private void FixedUpdate()
        {
            stopwatchLabel.text = (_stopwatch.ElapsedMilliseconds / 1000).ToString();
            if (State.Lost.Equals(gameState.State))
            {
                label.text = "Cargo Destroyed!";
                label.enabled = true;
                _stopwatch.Stop();
            }
        }
    }
}
