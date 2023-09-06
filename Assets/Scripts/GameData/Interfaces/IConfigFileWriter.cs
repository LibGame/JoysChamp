using Assets.Scripts.GameData.Configs;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Interfaces
{
    public interface IConfigFileWriter
    {
        public void WriteAllFiles();
        public void WriteFile<T>(object config, string configName);
    }
}