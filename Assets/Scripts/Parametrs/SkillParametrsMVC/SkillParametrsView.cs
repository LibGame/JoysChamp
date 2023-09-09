using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.SkillParametrsMVC
{
    public class SkillParametrsView : MonoBehaviour , ISkillParametrsView
    {
        [SerializeField] private TMP_Text _bluntWeaponText;
        [SerializeField] private TMP_Text _stabbingWeaponText;
        [SerializeField] private TMP_Text _slashingWeaponText;
        [SerializeField] private TMP_Text _thrownWeaponText;
        [SerializeField] private TMP_Text _magicText;

        [Inject] private IGetSkill _skillParametrsModel;

        private Dictionary<SkillTypes, Action<int>> _skillUpdateMethods;

        private void Awake()
        {

            CreateUpdateSkillHandlers();
        }

        private void CreateUpdateSkillHandlers()
        {
            _skillUpdateMethods = new Dictionary<SkillTypes, Action<int>>
            {
                { SkillTypes.Blunt_Weapon, UpdateBluntWeapon },
                { SkillTypes.Stabbing_Weapon, UpdateStabbingWeapon },
                { SkillTypes.Slashing_Weapon, UpdateSlashingWeapon },
                { SkillTypes.Thrown_Weapons, UpdateThrownWeapon },
                { SkillTypes.Magic, UpdateMagicWeapon }
            };
        }

        private void OnDestroy()
        {
            _skillParametrsModel.OnAddedSkills -= AddedSkillTypesHandler;
            foreach (var item in _skillParametrsModel.Skills)
                item.OnChangeSkill -= HandleSkillUpdate;
        }

        private void AddedSkillTypesHandler()
        {
            foreach (var item in _skillParametrsModel.Skills)
                item.OnChangeSkill += HandleSkillUpdate;
        }


        public void HandleSkillUpdate(SkillTypes skillType ,int percent)
        {
            if (_skillUpdateMethods.ContainsKey(skillType))
            {
                _skillUpdateMethods[skillType](percent);
            }
            else
            {
                Debug.LogWarning("No update method found for skill type: " + skillType);
            }

        }

        public void UpdateBluntWeapon(int percent)
        {
            _bluntWeaponText.text = percent.ToString() + "%";
        }

        public void UpdateStabbingWeapon(int percent)
        {
            _stabbingWeaponText.text = percent.ToString() + "%";
        }

        public void UpdateSlashingWeapon(int percent)
        {
            _slashingWeaponText.text = percent.ToString() + "%";
        }

        public void UpdateThrownWeapon(int percent)
        {
            _thrownWeaponText.text = percent.ToString() + "%";
        }

        public void UpdateMagicWeapon(int percent)
        {
            _magicText.text = percent.ToString() + "%";
        }
    }
}