using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Interfaces
{
    public interface IConfig
    {
        string ConfigName { get; }
        void SetValues<T>(T config);
    }
}