using Assets.Scripts.Game.Interfaces;
using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.ScoreParametrsMVC;
using Assets.Scripts.SkillParametrsMVC;
using System;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Game
{
    public class GameStarter : MonoBehaviour , IGameStarter
    {
        [Inject] private ScoreParametrsController _scoreParametrsController;
        [Inject] private SkillParametrsController _skillParametrsController;
        [Inject] private IConfigFilesReader _configFilesReader;
        [Inject] private GameLoop _gameLoop;

        public event Action OnGameStarted;

        private void Start()
        {
            _configFilesReader.OnInitedData += StartGame;
            _configFilesReader.LoadConfigs();
        }

        public void StartGame()
        {
            _scoreParametrsController.Init();
            _skillParametrsController.Init();
            _gameLoop.StartGameLoop();
            OnGameStarted?.Invoke();
        }

    }
}