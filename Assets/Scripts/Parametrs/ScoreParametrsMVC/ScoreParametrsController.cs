using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.ScoreParametrsMVC
{
    public class ScoreParametrsController : MonoBehaviour
    {
        [Inject] private IScoreParametrsViewInterface _scoreParametrsViewInterface;
        [Inject] private IScoreParametrsInit _scoreParametrsModel;

        public void Init(IScoreParametrModel scoreParametrModel)
        {
            _scoreParametrsModel.Init(scoreParametrModel);

            _scoreParametrsViewInterface.UpdateHelthBar();
            _scoreParametrsViewInterface.UpdateManaBar();
            _scoreParametrsViewInterface.UpdateStaminaBar();
            _scoreParametrsViewInterface.UpdateGlory();
            _scoreParametrsViewInterface.UpdateMoney();
            _scoreParametrsViewInterface.UpdateExperience();
            _scoreParametrsViewInterface.UpdateMoral();
            _scoreParametrsViewInterface.UpdateRating();
        }
    }
}