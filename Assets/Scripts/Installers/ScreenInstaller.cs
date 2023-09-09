using Assets.Scripts.Screens;
using Assets.Scripts.Screens.CreateCharacterScreen;
using Assets.Scripts.Screens.MenuScreen;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class ScreenInstaller : MonoInstaller
    {
        [SerializeField] private ScreenContext _screenContext;
        [SerializeField] private CreateCharacterScreen _createCharacterScreen;
        [SerializeField] private MenuScreen _menuScreen;

        public override void InstallBindings()
        {
            Container.Bind<ScreenContext>().FromInstance(_screenContext).AsSingle();
            Container.Bind<CreateCharacterScreen>().FromInstance(_createCharacterScreen).AsSingle();
            Container.Bind<MenuScreen>().FromInstance(_menuScreen).AsSingle();
        }

    }
}