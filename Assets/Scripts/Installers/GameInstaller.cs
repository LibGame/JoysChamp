using Assets.Scripts.Game;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameLoop _gameLoop;
        [SerializeField] private GameStarter _gameStarter;
        [SerializeField] private GameState _gameState;

        public override void InstallBindings()
        {
            Container.Bind<GameState>().FromInstance(_gameState).AsSingle();
            Container.Bind<GameStarter>().FromInstance(_gameStarter).AsSingle();
            Container.Bind<GameLoop>().FromInstance(_gameLoop).AsSingle();  
        }
    }
}