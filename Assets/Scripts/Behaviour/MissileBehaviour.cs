using Entity;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Behaviour
{
    public class MissileBehaviour : DagerousObject
    {
        public float minSpeed = 500f;
        public float maxSpeed = 1000f;

        // Start is called before the first frame update
        void Start()
        {
            CreateAlertIcon();
        }

        // Update is called once per frame
        void Update() 
        {
            transform.Translate(Vector3.up * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
        
            if (transform.position.y >= maxHeight)
            {
                Destroy();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<PlayerHealthBehaviour>().TakeDamage();
                Destroy();
            }
        }
    }
}
