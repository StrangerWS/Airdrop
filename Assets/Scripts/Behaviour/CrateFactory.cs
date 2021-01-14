using System;
using Consts;
using Entity;
using UnityEngine;

namespace DefaultNamespace
{
    public class CrateFactory : MonoBehaviour
    {
        public Transform spawnPoint;
        public CrateType CrateType;

        private void Update()
        {
            generateNewCrate(spawnPoint, CrateType);
        }

        private void generateNewCrate(Transform spawnPoint, CrateType crateType)
        {
            Crate crate = new Crate(spawnPoint, crateType);
            Instantiate(crate, spawnPoint);
        }
    }
}