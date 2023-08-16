using System;
using UnityEngine;

namespace Behaviour
{
    public class AbstractCrateController : MonoBehaviour
    {

        public int bounds = 15;
        public float movementSpeed = 5.0f;

        public float fallSpeed = 0f;
        // Start is called before the first frame update

        // Update is called once per frame
        private void Update()
        {
            var horizontalVector = Input.GetAxis("Horizontal");
        
            var xMovement = horizontalVector * Time.deltaTime * movementSpeed;
            var yMovement = fallSpeed * Time.deltaTime * -1;
        
            transform.Translate(new Vector3(xMovement, yMovement, 0));
            Vector3 position = transform.position;

            position.x = Mathf.Clamp(position.x, -bounds, bounds);
            position.z = Mathf.Clamp(position.z, -bounds, bounds);
            //position.y = Mathf.Clamp(position.y, 0, float.MaxValue);

            transform.position = position;
        }
    }
}
