using Assets.Scripts.GameData.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC.Interfaces
{
    public interface ISkillParametrsModel
    {
        public event Action OnAddedSkills;

        public int GetSkillPercentByType(SkillTypes skillType);

        public void DecreaseSkillPercentByType(int skillPercent, SkillTypes skillType);

        public void IncreaseSkillPercentByType(int skillPercent, SkillTypes skillType);
    }

    public interface ISkillEnumerable
    {
        IEnumerable<ISkill> Skills { get; }
    }

    public interface IInitedSkillParametrsModel
    {
        public void SetSkillsFromConfig(ISkillParametrsConfing skillParametrsConfing);
    }
}