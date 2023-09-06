using Assets.Scripts.GameData;
using Assets.Scripts.GameData.Configs;
using Assets.Scripts.GameData.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class GameDataInstaller : MonoInstaller
    {
        [SerializeField] private ScoreParametrsConfig _scoreParametrsConfig;
        [SerializeField] private SkillParametrsConfing _skillParametrsConfing;
        [SerializeField] private ConfigFilesReader _configFilesReader;
        [SerializeField] private ConfigFileWriter _configFileWriter;

        public override void InstallBindings()
        {
            Container.Bind<IScoreParametrsConfig>().FromInstance(_scoreParametrsConfig).AsSingle();
            Container.Bind<ISkillParametrsConfing>().FromInstance(_skillParametrsConfing).AsSingle();
            Container.Bind<IConfigFilesReader>().FromInstance(_configFilesReader).AsSingle();
            Container.Bind<IConfigFileWriter>().FromInstance(_configFileWriter).AsSingle();
        }
    }
}