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
            Container.Bind<IScoreParametrsViewInterface>().To<ScoreParametrsView>().FromInstance(_scoreParametrsView);
            Container.Bind<ScoreParametrsController>().FromInstance(_scoreParametrsController);
            Container.Bind<IScoreParametrModel>().To<ScoreParametrsModel>().FromInstance(_scoreParametrsModel);
            Container.Bind<IScoreParametrsInit>().To<ScoreParametrsModel>().FromInstance(_scoreParametrsModel);
        }
    }
}