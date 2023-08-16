using System;
using Consts;
using UnityEngine;

namespace Behaviour
{
    public class PlayerHealthBehaviour: MonoBehaviour
    {
        public GameState gameState;
        public int hits = 3;

        public void TakeDamage()
        {
            hits--;
            if (hits == 0 && State.Lost != gameState.State)
            {
                gameState.State = State.Lost;
                Destroy(this.gameObject);
            }
        }
    }
}