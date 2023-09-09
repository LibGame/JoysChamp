using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.PlayerMVC.Interfaces;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.PlayerMVC
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private PlayerModel _playerModel;
        [Inject] private IScoreParametrsConfig _scoreParametrsConfig;
        [Inject] private ISkillParametrsConfing _skillParametrsConfing;

        public IScoreParametrModel GetScoreParametrModel()
        {
            return _playerModel;
        }

        public ISkillParametrsModel GetSkillParametrsModel()
        {
            return _playerModel;
        }

        public void Init()
        {
            _playerModel.SetScoreParametrsFromConfig(_scoreParametrsConfig);
            _playerModel.SetSkillsParametrsFromConfig(_skillParametrsConfing);
        }
    }
}