using Assets.Scripts.Screens.MenuScreen.Panels;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class PanelsInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInfoPanel _playerInfoPanel;

        public override void InstallBindings()
        {
            Container.Bind<PlayerInfoPanel>().FromInstance(_playerInfoPanel).AsSingle();
        }

    }
}