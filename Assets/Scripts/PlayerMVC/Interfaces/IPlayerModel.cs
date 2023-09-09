using Assets.Scripts.GameData.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.PlayerMVC.Interfaces
{
    public interface IPlayerModel 
    {
        void SetScoreParametrsFromConfig(IScoreParametrsConfig config);
        void SetSkillsParametrsFromConfig(ISkillParametrsConfing skillParametrsModel);
    }
}