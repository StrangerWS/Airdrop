using System;
using Behaviour;
using Consts;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Entity
{
    public class ObjectSpawner : MonoBehaviour
    {
        public GameState gameState;

        public DagerousObject objectToSpawn;

        public Transform objectToTarget;

        public int spawnRate = 3;
        public int objectsInGroup = 4;
        
        public Canvas canvas;
        
        private float _spawnDistance = 150;
        private int _range = 15;

        // Start is called before the first frame update
        private void Start()
        {
            InvokeRepeating(nameof(SpawnObjectGroup), spawnRate, spawnRate);
        }


        private void SpawnObjectGroup()
        {
            if (!State.Playing.Equals(gameState.State))
            {
                return;
            }
            for (var i = 0; i < objectsInGroup; i++)
            {
                SpawnObject();
            }
        }

        private void SpawnObject()
        {
            DagerousObject spawnedObject = Instantiate(objectToSpawn, GetRandomPositionWithinBounds(), Quaternion.identity);
            spawnedObject.canvas = this.canvas;
            spawnedObject.maxHeight = objectToTarget.position.y + _spawnDistance;
        }

        private Vector3 GetRandomPositionWithinBounds()
        {
            var x = Random.Range(-_range, _range);
            return new Vector3(x, objectToTarget.position.y - _spawnDistance, 0);
        }
    }
}
