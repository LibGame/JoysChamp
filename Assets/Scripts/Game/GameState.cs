using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameState : MonoBehaviour
    {
        [SerializeField] private GameStates _currentGameState = GameStates.CreateCharacter;
        [SerializeField] private GameStates _previousGameState = GameStates.CreateCharacter;

        public GameStates PreviouseGameState => _previousGameState;
        public GameStates CurrentGameState => _currentGameState;

        public event Action OnChangeGameState;

        public void ChangeGameeSate(GameStates gameState)
        {
            _previousGameState = _currentGameState;
            _currentGameState = gameState;
            OnChangeGameState();
        }

    }
}