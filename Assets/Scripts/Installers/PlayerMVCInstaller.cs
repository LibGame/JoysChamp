using Assets.Scripts.PlayerMVC;
using Assets.Scripts.PlayerMVC.Interfaces;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using Assets.Scripts.SkillParametrsMVC;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class PlayerMVCInstaller : MonoInstaller
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private PlayerController _playerController;
        [SerializeField] private PlayerModel _playerModel;

        public override void InstallBindings()
        {
            Container.Bind<PlayerView>().FromInstance(_playerView);
            Container.Bind<PlayerController>().FromInstance(_playerController);
            Container.Bind<PlayerModel>().FromInstance(_playerModel);
            //Container.Bind<ISkillParametrsModel>().To<PlayerModel>().FromInstance(_playerModel);
            //Container.Bind<IScoreParametrModel>().To<PlayerModel>().FromInstance(_playerModel);

        }
    }
}