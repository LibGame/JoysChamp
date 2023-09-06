using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class SkillParametrsModel : MonoBehaviour , ISkillParametrsModel , IInitedSkillParametrsModel , ISkillEnumerable
    {
        private List<ISkill> _skills = new List<ISkill>();

        public event Action OnAddedSkills;

        public IEnumerable<ISkill> Skills => _skills;


        private bool TryGetSkillByType(out ISkill skill, SkillTypes skillType)
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

        public void DecreaseSkillPercentByType(int skillPercent, SkillTypes skillType)
        {
            if (TryGetSkillByType(out ISkill skill, skillType))
            {
                skill.DecreasePercet(skillPercent);
            }
        }

        public void IncreaseSkillPercentByType(int skillPercent, SkillTypes skillType)
        {
            if (TryGetSkillByType(out ISkill skill , skillType))
            {
                skill.IncreasePercet(skillPercent);
            }
        }
 
        public void SetSkillsFromConfig(ISkillParametrsConfing skillParametrsConfing)
        {
            _skills.Add(new Skill(skillParametrsConfing.BluntWeapon, SkillTypes.Blunt_Weapon));
            _skills.Add(new Skill(skillParametrsConfing.ThrownWeapons, SkillTypes.Thrown_Weapons));
            _skills.Add(new Skill(skillParametrsConfing.SlashingWeapon, SkillTypes.Slashing_Weapon));
            _skills.Add(new Skill(skillParametrsConfing.StabbingWeapon, SkillTypes.Stabbing_Weapon));
            _skills.Add(new Skill(skillParametrsConfing.Magic, SkillTypes.Magic));
            OnAddedSkills?.Invoke();
        }
    }
}