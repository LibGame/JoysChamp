using Assets.Scripts.GameData.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.ScoreParametrsMVC.Interfaces
{
    public interface IScoreParametrsInit
    {
        void Init(IScoreParametrModel scoreParametrModel);
    }
}