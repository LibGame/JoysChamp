using Assets.Scripts.GameData.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC.Interfaces
{
    public interface ISkillParametrsModel : IGetSkill
    {

        public void DecreaseSkillPercentByType(int skillPercent, SkillTypes skillType);

        public void IncreaseSkillPercentByType(int skillPercent, SkillTypes skillType);
    }

    public interface ISkillEnumerable
    {
        IEnumerable<ISkill> Skills { get; }
        public event Action OnAddedSkills;
    }

    public interface IGetSkill : ISkillEnumerable
    {
        public int GetSkillPercentByType(SkillTypes skillType);
        public bool TryGetSkillByType(out ISkill skill, SkillTypes skillType);
    }

    public interface IInitedSkillParametrs
    {
        public void InitSkills(ISkillParametrsModel skillParametrsModel);
    }
}