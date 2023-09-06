using Assets.Scripts.GameData.Configs;
using Assets.Scripts.GameData.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Assets.Scripts.GameData
{
    [CreateAssetMenu(fileName = "ConfigFilesReader", menuName = "ScriptableObjects/ConfigFilesReader")]
    public class ConfigFilesReader : ScriptableObject , IConfigFilesReader
    {
        [SerializeField] private SkillParametrsConfing _skillParametrsConfing;
        [SerializeField] private ScoreParametrsConfig _scoreParametrsConfig;

        public event Action OnInitedData;
        private int _initedConfigurations;
        private List<IConfig> _configs = new List<IConfig>();

        public void LoadConfigs()
        {
            _configs.Add(_scoreParametrsConfig);
            _configs.Add(_skillParametrsConfing);

            ReadFile<SkillParametrsConfing>(_skillParametrsConfing);
            ReadFile<ScoreParametrsConfig>(_scoreParametrsConfig);
        }

        private void InitedConfig()
        {
            _initedConfigurations++;
            if (_initedConfigurations == _configs.Count)
                OnInitedData?.Invoke();
        }

        public void ReadFile<T>(IConfig configHandler)
        {
#if UNITY_EDITOR
            string path = Path.Combine(Application.streamingAssetsPath, configHandler.ConfigName);
            var json = File.ReadAllText(path);
            T config = JsonConvert.DeserializeObject<T>(json);
            configHandler.SetValues(config);
            InitedConfig();
#else
            StartCoroutine(GetJsonData<T>(configHandler, configHandler.ConfigName));
#endif

        }

        private IEnumerator GetJsonData<T>(IConfig configHandler, string jsonUrl)
        {
            string filePath;
            filePath = Path.Combine(Application.streamingAssetsPath, jsonUrl);
            string dataAsJson;
            if (filePath.Contains("://") || filePath.Contains(":///"))
            {
                WWW www = new WWW(filePath);
                while (!www.isDone)
                {
                    yield return null;
                }
                dataAsJson = www.text;
            }
            else
            {
                dataAsJson = File.ReadAllText(filePath);
            }

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            T config = JsonConvert.DeserializeObject<T>(dataAsJson, settings);
            configHandler.SetValues(config);
            InitedConfig();
        }
    }
}