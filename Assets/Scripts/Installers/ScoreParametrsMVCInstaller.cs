using Assets.Scripts.ScoreParametrsMVC;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class ScoreParametrsMVCInstaller : MonoInstaller
    {
        [SerializeField] private ScoreParametrsModel _scoreParametrsModel;
        [SerializeField] private ScoreParametrsController _scoreParametrsController;
        [SerializeField] private ScoreParametrsView _scoreParametrsView;
        
        public override void InstallBindings()
        {
            Container.Bind<IScoreParametrsViewInterface>().FromInstance(_scoreParametrsView).AsSingle();
            Container.Bind<ScoreParametrsController>().FromInstance(_scoreParametrsController).AsSingle();
            Container.Bind<ScoreParametrsModel>().FromInstance(_scoreParametrsModel).AsSingle();
        }
    }
}