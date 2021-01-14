using Consts;
using UnityEngine;

namespace Entity
{
    public class Crate :  BaseEntity
    {
        //The fall speed of the crate. Should be always positive.
        public float FallSpeed = EnvironmentConsts.ParachuteFallSpeed;

        //The crate type for crate. Defines the contents after landing and amount of shots required to destroy the crate
        public CrateType CrateType;

        public Crate(Transform position, CrateType crateType): base(position)
        {
            this.CrateType = crateType;
        }
    }
}