using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Scripts.ScoreParametrsMVC
{
    public class ScoreParametrsView : MonoBehaviour , IScoreParametrsViewInterface
    {
        [SerializeField] private Image _healthBar;
        [SerializeField] private Image _manaBar;
        [SerializeField] private Image _staminaBar;
        [SerializeField] private TMP_Text _gloryPointsText;
        [SerializeField] private TMP_Text _moneyText;
        [SerializeField] private TMP_Text _experienceText;
        [SerializeField] private TMP_Text _moralText;
        [SerializeField] private TMP_Text _ratingText;

        [Inject] private ScoreParametrsModel _scoreParametrModel;

        private void OnEnable()
        {
            _scoreParametrModel.OnExperienceChange += UpdateExperience;
            _scoreParametrModel.OnManaChange += UpdateManaBar;
            _scoreParametrModel.OnManaMaxChange += UpdateManaBar;
            _scoreParametrModel.OnStaminaChange += UpdateStaminaBar;
            _scoreParametrModel.OnGloryPointsChange += UpdateGlory;
            _scoreParametrModel.OnRatingChange += UpdateRating;
            _scoreParametrModel.OnHealthChange += UpdateHelthBar;
            _scoreParametrModel.OnHealthMaxChange += UpdateHelthBar;
            _scoreParametrModel.OnMoneyChange += UpdateMoney;
            _scoreParametrModel.OnMoralChange += UpdateMoral;
            _scoreParametrModel.OnStaminaMaxChange += UpdateStaminaBar;
        }

        private void OnDisable()
        {
            _scoreParametrModel.OnExperienceChange -= UpdateExperience;
            _scoreParametrModel.OnManaChange -= UpdateManaBar;
            _scoreParametrModel.OnManaMaxChange -= UpdateManaBar;
            _scoreParametrModel.OnStaminaChange -= UpdateStaminaBar;
            _scoreParametrModel.OnGloryPointsChange -= UpdateGlory;
            _scoreParametrModel.OnRatingChange -= UpdateRating;
            _scoreParametrModel.OnHealthChange -= UpdateHelthBar;
            _scoreParametrModel.OnHealthMaxChange -= UpdateHelthBar;
            _scoreParametrModel.OnMoneyChange -= UpdateMoney;
            _scoreParametrModel.OnMoralChange -= UpdateMoral;
            _scoreParametrModel.OnStaminaMaxChange -= UpdateStaminaBar;
        }

        public void UpdateHelthBar()
        {
            _healthBar.fillAmount = (float)_scoreParametrModel.Health / (float)_scoreParametrModel.HealthMax;
        }

        public void UpdateManaBar()
        {
            _manaBar.fillAmount = (float)_scoreParametrModel.Mana / (float)_scoreParametrModel.ManaMax;
        }

        public void UpdateStaminaBar()
        {
            _staminaBar.fillAmount = (float)_scoreParametrModel.Stamina / (float)_scoreParametrModel.StaminaMax;
        }

        public void UpdateGlory()
        {
            _gloryPointsText.text = _scoreParametrModel.GloryPoints.ToString();
        }

        public void UpdateMoney()
        {
            _moneyText.text = _scoreParametrModel.Money.ToString();
        }

        public void UpdateExperience()
        {
            _experienceText.text = _scoreParametrModel.Experience.ToString();
        }

        public void UpdateMoral()
        {
            _moralText.text = _scoreParametrModel.Moral.ToString();
        }

        public void UpdateRating()
        {
            _ratingText.text = _scoreParametrModel.Rating.ToString();
        }

    }
}