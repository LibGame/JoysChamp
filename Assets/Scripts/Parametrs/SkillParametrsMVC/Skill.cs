using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class Skill : ISkill
    {
        private int _percent;
        public SkillTypes Type { get; private set; }

        public int Percent => _percent;

        public event Action<SkillTypes, int> OnChangeSkill;

        public Skill(int bonusPercent, SkillTypes type)
        {
            _percent = bonusPercent;
            Type = type;
        }

        public void IncreasePercet(int count)
        {
            _percent += count;
            BringBonusToCorectValue();
            OnChangeSkill?.Invoke(Type, Percent);
        }

        public void DecreasePercet(int count)
        {
            _percent -= count;
            BringBonusToCorectValue();
            OnChangeSkill?.Invoke(Type, Percent);
        }

        private void BringBonusToCorectValue()
        {
            if (_percent < 0)
                _percent = 0;
            if (_percent > 100)
                _percent = 100;
        }

        public void SetPercent(int percent)
        {
            _percent = percent;
            BringBonusToCorectValue();
            OnChangeSkill?.Invoke(Type, Percent);
        }
    }
}