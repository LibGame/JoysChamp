using System.Collections;
using UnityEngine;

namespace Assets.Scripts.ScoreParametrsMVC.Interfaces
{
    public interface IScoreParametrsViewInterface
    {
        public void UpdateHelthBar();

        public void UpdateManaBar();

        public void UpdateStaminaBar();

        public void UpdateGlory();

        public void UpdateMoney();

        public void UpdateExperience();

        public void UpdateMoral();

        public void UpdateRating();
    }
}