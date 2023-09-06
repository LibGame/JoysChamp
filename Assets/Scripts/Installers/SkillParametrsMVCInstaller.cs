using UnityEngine;
using Zenject;
using Assets.Scripts.SkillParametrsMVC;
using Assets.Scripts.SkillParametrsMVC.Interfaces;

namespace Assets.Scripts.Installers
{
    public class SkillParametrsMVCInstaller : MonoInstaller
    {
        [SerializeField] private SkillParametrsModel _skillParametrsModel;
        [SerializeField] private SkillParametrsController _skillParametrsController;
        [SerializeField] private SkillParametrsView _skillParametrsView;

        public override void InstallBindings()
        {
            Container.Bind<ISkillParametrsView>().FromInstance(_skillParametrsView).AsSingle();
            Container.Bind<SkillParametrsController>().FromInstance(_skillParametrsController).AsSingle();
            Container.Bind<ISkillParametrsModel>().FromInstance(_skillParametrsModel).AsSingle();
            Container.Bind<IInitedSkillParametrsModel>().FromInstance(_skillParametrsModel).AsSingle();
            Container.Bind<ISkillEnumerable>().FromInstance(_skillParametrsModel).AsSingle();
        }

    }
}