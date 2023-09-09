using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class SkillParametrsController : MonoBehaviour
    {
        [Inject] private IInitedSkillParametrs _initedSkillParametrsModel;
        [Inject] private ISkillParametrsView _skillParametrsView;
        [Inject] private ISkillEnumerable _skillEnumerable;

        public void Init(ISkillParametrsModel skillParametrsModel)
        {
            _initedSkillParametrsModel.InitSkills(skillParametrsModel);
            foreach(var skill in _skillEnumerable.Skills)
            {
                _skillParametrsView.HandleSkillUpdate(skill.Type, skill.Percent);
            }
        }

    }
}