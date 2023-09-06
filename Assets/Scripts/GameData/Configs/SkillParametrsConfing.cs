using Assets.Scripts.GameData.Interfaces;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Configs
{
    [CreateAssetMenu(fileName = "SkillParametrsConfing", menuName = "ScriptableObjects/SkillParametrsConfing")]
    [Serializable]
    public class SkillParametrsConfing : ScriptableObject , ISkillParametrsConfing , IConfig
    {
        [field: SerializeField] public int BluntWeapon { get; set; }
        [field: SerializeField] public int StabbingWeapon { get; set; }
        [field: SerializeField] public int SlashingWeapon { get; set; }
        [field: SerializeField] public int ThrownWeapons { get; set; }
        [field: SerializeField] public int Magic { get; set; }

        public string ConfigName => "SkillParametrsConfing.json";

        public void SetValues<T>(T config)
        {
            if(config is SkillParametrsConfing skillParametrsConfing)
            {
                BluntWeapon = skillParametrsConfing.BluntWeapon;
                StabbingWeapon = skillParametrsConfing.StabbingWeapon;
                SlashingWeapon = skillParametrsConfing.SlashingWeapon;
                ThrownWeapons = skillParametrsConfing.SlashingWeapon;
                Magic = skillParametrsConfing.Magic;
            }
            else
            {
                Debug.LogError("Wrong config type");
            }
        }
    }
}