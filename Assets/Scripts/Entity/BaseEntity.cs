using UnityEngine;

namespace Entity

{
    public class BaseEntity : MonoBehaviour
    {
        public Transform position;

        public BaseEntity(Transform position)
        {
            this.position = position;
        }
    }
}
