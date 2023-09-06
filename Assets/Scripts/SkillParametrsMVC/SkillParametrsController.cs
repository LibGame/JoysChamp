using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class SkillParametrsController : MonoBehaviour
    {
        [Inject] private IInitedSkillParametrsModel _initedSkillParametrsModel;
        [Inject] private ISkillParametrsConfing _skillParametrsConfing;

        public void Init()
        {
            _initedSkillParametrsModel.SetSkillsFromConfig(_skillParametrsConfing);
        }

    }
}