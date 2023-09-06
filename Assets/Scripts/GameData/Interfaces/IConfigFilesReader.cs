using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Interfaces
{
    public interface IConfigFilesReader
    {
        event Action OnInitedData;
        void LoadConfigs();
    }
}