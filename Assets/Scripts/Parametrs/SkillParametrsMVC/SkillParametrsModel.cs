using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class SkillParametrsModel : MonoBehaviour, IGetSkill, IInitedSkillParametrs , ISkillEnumerable
    {
        private List<ISkill> _skills = new List<ISkill>();

        public event Action OnAddedSkills;

        public IEnumerable<ISkill> Skills => _skills;

        public int GetSkillPercentByType(SkillTypes skillType)
        {
            ISkill skill = _skills.SingleOrDefault(x => x.Type == skillType);
            if (skill == null)
            {
                Debug.LogError("Not founded skill by type: " + skillType);
                return 0;
            }
            return skill.Percent;
        }

        public void SetSkillPercentByType(SkillTypes skillType, int percent)
        {
            if(TryGetSkillByType(out ISkill skill , skillType))
                skill.SetPercent(percent);
        }

        public void InitSkills(ISkillParametrsModel skillParametrsModel)
        {
            _skills = new List<ISkill>(skillParametrsModel.Skills);
            OnAddedSkills?.Invoke();
        }

        public bool TryGetSkillByType(out ISkill skill, SkillTypes skillType)
        {
            skill = _skills.SingleOrDefault(x => x.Type == skillType);

            if (skill != null)
            {
                return true;
            }
            else
            {
                Debug.LogError("Not founded skill by type: " + skillType);
                return false;
            }
        }
    }
}