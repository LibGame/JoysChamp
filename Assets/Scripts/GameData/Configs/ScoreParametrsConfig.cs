using Assets.Scripts.GameData.Interfaces;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Configs
{
    [CreateAssetMenu(fileName = "ScoreParametrsConfig", menuName = "ScriptableObjects/ScoreParametrsConfig")]
    [Serializable]
    public class ScoreParametrsConfig : ScriptableObject, IScoreParametrsConfig, IConfig
    {
        [field: SerializeField] public int Health { get; set; }
        [field: SerializeField] public int HealthMax { get; set; }

        [field: SerializeField] public int Mana { get; set; }
        [field: SerializeField] public int ManaMax { get; set; }

        [field: SerializeField] public int Stamina { get; set; }
        [field: SerializeField] public int StaminaMax { get; set; }

        [field: SerializeField] public float Experience { get; set; }
        [field: SerializeField] public int Money { get; set; }
        [field: SerializeField] public float GloryPoints { get; set; }
        [field: SerializeField] public int Moral { get; set; }
        [field: SerializeField] public int Rating { get; set; }

        public string ConfigName => "ScoreParametrsConfig.json";


        public void SetValues<T>(T config)
        {
            if (config is ScoreParametrsConfig scoreParametrsConfig)
            {
                Health = scoreParametrsConfig.Health;
                HealthMax = scoreParametrsConfig.HealthMax;
                Mana = scoreParametrsConfig.Mana;
                ManaMax = scoreParametrsConfig.ManaMax;
                Stamina = scoreParametrsConfig.Stamina;
                StaminaMax = scoreParametrsConfig.StaminaMax;
                Experience = scoreParametrsConfig.Experience;
                Money = scoreParametrsConfig.Money;
                GloryPoints = scoreParametrsConfig.GloryPoints;
                Moral = scoreParametrsConfig.Moral;
                Rating = scoreParametrsConfig.Rating;
            }
            else
            {
                Debug.LogError("Wrong config type");
            }
        }
    }
}