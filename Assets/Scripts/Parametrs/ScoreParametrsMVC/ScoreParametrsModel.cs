using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using System;
using System.Collections;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Assets.Scripts.ScoreParametrsMVC
{
    public class ScoreParametrsModel : MonoBehaviour , IScoreParametrModel , IScoreParametrsInit
    {
        public int Health { get; private set; }
        public int HealthMax { get; private set; }

        public int Mana { get; private set; }
        public int ManaMax { get; private set; }

        public int Stamina { get; private set; }
        public int StaminaMax { get; private set; }

        public float Experience { get; private set; }
        public int Money { get; private set; }
        public float GloryPoints { get; private set; }
        public int Moral { get; private set; }
        public int Rating { get; private set; }


        public event Action OnHealthChange;
        public event Action OnHealthMaxChange;

        public event Action OnManaChange;
        public event Action OnManaMaxChange;

        public event Action OnStaminaChange;
        public event Action OnStaminaMaxChange;

        public event Action OnExperienceChange;
        public event Action OnMoneyChange;
        public event Action OnGloryPointsChange;
        public event Action OnMoralChange;
        public event Action OnRatingChange;

        public void Init(IScoreParametrModel scoreParametrModel)
        {
            SetHealth(scoreParametrModel.Health);
            SetMaxHealth(scoreParametrModel.HealthMax);
            SetMana(scoreParametrModel.Mana);
            SetMaxMana(ManaMax = scoreParametrModel.ManaMax);
            SetStamina(scoreParametrModel.Stamina);
            SetMaxStamina(scoreParametrModel.StaminaMax);
            SetExperience(scoreParametrModel.Experience);
            SetMoney(scoreParametrModel.Money);
            SetGloryPoints(scoreParametrModel.GloryPoints);
            SetMoral(scoreParametrModel.Moral);
            SetRating(scoreParametrModel.Rating);
        }

        public void SetMaxMana(int manaMax)
        {
            ManaMax = manaMax;
            OnManaMaxChange?.Invoke();
        }

        public void SetMaxHealth(int healthMax)
        {
            HealthMax = healthMax;
            OnHealthMaxChange?.Invoke();
        }

        public void SetMaxStamina(int staminaMax)
        {
            StaminaMax = staminaMax;
            OnStaminaMaxChange?.Invoke();
        }

        public void SetRating(int count)
        {
            Rating = count;
            OnRatingChange?.Invoke();
        }

        public void SetMoral(int count)
        {
            Moral = count;
            OnMoralChange?.Invoke();
        }

        public void SetGloryPoints(float count)
        {
            GloryPoints = count;
            OnGloryPointsChange?.Invoke();
        }

        public void SetMoney(int count)
        {
            Money = count;
            OnMoneyChange?.Invoke();
        }

        public void SetExperience(float count)
        {
            Experience = count;
            OnExperienceChange?.Invoke();
        }

        public void SetStamina(int count)
        {
            Stamina = count;
            OnStaminaChange?.Invoke();
        }

        public void SetHealth(int count)
        {
            Health = count;
            OnHealthChange?.Invoke();
        }

        public void SetMana(int count)
        {
            Mana = count;
            OnManaChange?.Invoke();
        }

    }
}