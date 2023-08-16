using UnityEngine;

namespace Consts
{
    [CreateAssetMenu(fileName = "GameState", menuName = "States/GameState")]
    public class GameState : ScriptableObject
    {
        public State State;
    }
}