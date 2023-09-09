using Assets.Scripts.GameData.Interfaces;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.ScoreParametrsMVC.Interfaces
{
    public interface IScoreParametrModel
    {
        int Health { get; }
        int HealthMax { get; }
        
        int Mana { get; }
        int ManaMax { get; }
        
        int Stamina { get; }
        int StaminaMax { get; }
        
        float Experience { get; }
        int Money { get; }
        float GloryPoints { get; }
        int Moral { get; }
        int Rating { get; }



        event Action OnHealthChange;
        event Action OnHealthMaxChange;

        event Action OnManaChange;
        event Action OnManaMaxChange;

        event Action OnStaminaChange;
        event Action OnStaminaMaxChange;

        event Action OnExperienceChange;
        event Action OnMoneyChange;
        event Action OnGloryPointsChange;
        event Action OnMoralChange;
        event Action OnRatingChange;

    }
}