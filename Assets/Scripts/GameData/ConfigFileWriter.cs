using Assets.Scripts.GameData.Configs;
using Assets.Scripts.GameData.Interfaces;
using Newtonsoft.Json;
using System.Collections;
using System.IO;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.GameData
{
    [CreateAssetMenu(fileName = "ConfigFileWriter", menuName = "ScriptableObjects/ConfigFileWriter")]
    public class ConfigFileWriter : ScriptableObject , IConfigFileWriter
    {
        [SerializeField] private SkillParametrsConfing _skillParametrsConfing;
        [SerializeField] private ScoreParametrsConfig _scoreParametrsConfig;

        public void WriteAllFiles()
        {
            WriteFile<SkillParametrsConfing>(_skillParametrsConfing, _skillParametrsConfing.ConfigName);
            WriteFile<ScoreParametrsConfig>(_scoreParametrsConfig, _scoreParametrsConfig.ConfigName);
            Debug.Log("Saved all configs");
        }

        public void WriteFile<T>(object config, string configName)
        {
            string path;

#if UNITY_EDITOR
            path = Path.Combine(Application.streamingAssetsPath, configName);
#else
            path = Path.Combine(Application.dataPath, configName);
#endif

            string jsonString = JsonConvert.SerializeObject((T)config, Formatting.Indented);
            File.WriteAllText(path, jsonString);
        }
    }
}