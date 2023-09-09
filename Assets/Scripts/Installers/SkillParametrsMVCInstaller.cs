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
            Container.Bind<SkillParametrsController>().FromInstance(_skillParametrsController);
            Container.Bind<IGetSkill>().To<SkillParametrsModel>().FromInstance(_skillParametrsModel);
            Container.Bind<ISkillEnumerable>().To<SkillParametrsModel>().FromInstance(_skillParametrsModel);
            Container.Bind<IInitedSkillParametrs>().To<SkillParametrsModel>().FromInstance(_skillParametrsModel);
            Container.Bind<ISkillParametrsView>().To<SkillParametrsView>().FromInstance(_skillParametrsView);

        }

    }
}