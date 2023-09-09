using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.PlayerMVC.Interfaces;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using Assets.Scripts.SkillParametrsMVC;
using Assets.Scripts.SkillParametrsMVC.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.PlayerMVC
{
    public class PlayerModel : MonoBehaviour, IPlayerModel, ISkillParametrsModel , IScoreParametrModel
    {
        private List<ISkill> _skills = new List<ISkill>();

        public IEnumerable<ISkill> Skills => _skills;

        public int Health {get; private set;}

        public int HealthMax { get; private set; }

        public int Mana { get; private set; }

        public int ManaMax { get; private set; }

        public int Stamina { get; private set; }

        public int StaminaMax {get; private set;}

        public float Experience {get; private set;}

        public int Money {get; private set;}

        public float GloryPoints {get; private set;}

        public int Moral {get; private set;}

        public int Rating {get; private set;}

        public event Action OnAddedSkills;
        public event Action OnHealthChange;
        public event Action OnHealthMaxChange;
        public event Action OnManaChange;
        public event Action OnManaMaxChange;
        public event Action OnStaminaChange;
        public event Action OnStaminaMaxChange;
        public event Action OnExperienceChange;
        public event Action OnMoneyChange;
        public event Action OnGloryPointsChange;
        public event Action OnMoralChange;
        public event Action OnRatingChange;

        public void SetScoreParametrsFromConfig(IScoreParametrsConfig config)
        {
            Health = config.Health;
            HealthMax = config.HealthMax;
            Mana = config.Mana;
            ManaMax = config.ManaMax;
            Stamina = config.Stamina;
            StaminaMax = config.StaminaMax;
            Experience = config.Experience;
            Money = config.Money;
            GloryPoints = config.GloryPoints;
            Moral = config.Moral;
            Rating = config.Rating;
        }

        public void SetSkillsParametrsFromConfig(ISkillParametrsConfing skillParametrsModel)
        {
            _skills.Clear();
            _skills.Add(new Skill(skillParametrsModel.BluntWeapon, SkillTypes.Blunt_Weapon));
            _skills.Add(new Skill(skillParametrsModel.ThrownWeapons, SkillTypes.Thrown_Weapons));
            _skills.Add(new Skill(skillParametrsModel.SlashingWeapon, SkillTypes.Slashing_Weapon));
            _skills.Add(new Skill(skillParametrsModel.StabbingWeapon, SkillTypes.Stabbing_Weapon));
            _skills.Add(new Skill(skillParametrsModel.Magic, SkillTypes.Magic));
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
            if (TryGetSkillByType(out ISkill skill, skillType))
            {
                skill.IncreasePercet(skillPercent);
            }
        }

        public void SetMaxMana(int manaMax)
        {
            ManaMax = manaMax;
            OnManaMaxChange?.Invoke();
        }

        public void SetMaxHealth(int healthMax)
        {
            HealthMax = healthMax;
            OnHealthMaxChange?.Invoke();
        }

        public void SetMaxStamina(int staminaMax)
        {
            StaminaMax = staminaMax;
            OnStaminaMaxChange?.Invoke();
        }

        public void IncreaseRating(int count)
        {
            Rating += count;
            if (Rating < 0)
                Rating = 0;
            OnRatingChange?.Invoke();
        }

        public void DecreaseRating(int count)
        {
            Rating -= count;
            if (Rating < 0)
                Rating = 0;
            OnRatingChange?.Invoke();
        }

        public void IncreaseMoral(int count)
        {
            Moral += count;
            OnMoralChange?.Invoke();
        }

        public void DecreaseMoral(int count)
        {
            Moral -= count;
            OnMoralChange?.Invoke();
        }

        public void IncreaseGloryPoints(float count)
        {
            GloryPoints += count;
            if (GloryPoints < 0)
                GloryPoints = 0;
            OnGloryPointsChange?.Invoke();
        }

        public void DecreaseGloryPoints(float count)
        {
            GloryPoints -= count;
            if (GloryPoints < 0)
                GloryPoints = 0;
            OnGloryPointsChange?.Invoke();
        }

        public void IncreaseMoney(int count)
        {
            Money += count;
            if (Money < 0)
                Money = 0;
            OnMoneyChange?.Invoke();
        }

        public void DecreaseMoney(int count)
        {
            Money -= count;
            if (Money < 0)
                Money = 0;
            OnMoneyChange?.Invoke();
        }


        public void IncreaseExperience(int count)
        {
            Experience += count;
            if (Experience < 0)
                Experience = 0;
            OnExperienceChange?.Invoke();
        }

        public void DecreaseExperience(int count)
        {
            Experience -= count;
            if (Experience < 0)
                Experience = 0;
            OnExperienceChange?.Invoke();
        }

        public void IncreaseStamina(int count)
        {
            Stamina += count;
            BringStaminaToCorectValue();
            OnStaminaChange?.Invoke();
        }

        public void DecreaseStamina(int count)
        {
            Stamina -= count;
            BringStaminaToCorectValue();
            OnStaminaChange?.Invoke();
        }

        public void IncreaseHealth(int count)
        {
            Health += count;
            BringHealthToCorectValue();
            OnHealthChange?.Invoke();
        }

        public void DecreaseHealth(int count)
        {
            Health -= count;
            BringHealthToCorectValue();
            OnHealthChange?.Invoke();
        }

        public void IncreaseMana(int count)
        {
            Mana += count;
            BringManaToCorectValue();
            OnManaChange?.Invoke();
        }

        public void DecreaseMana(int count)
        {
            Mana -= count;
            BringManaToCorectValue();
            OnManaChange?.Invoke();
        }

        public void BringStaminaToCorectValue()
        {
            if (Stamina > StaminaMax)
                Stamina = StaminaMax;
            if (Stamina < 0)
                Stamina = 0;
        }

        public void BringManaToCorectValue()
        {
            if (Mana > ManaMax)
                Mana = ManaMax;
            if (Mana < 0)
                Mana = 0;
        }

        public void BringHealthToCorectValue()
        {
            if (Health > HealthMax)
                Health = HealthMax;
            if (Health < 0)
                Health = 0;
        }
    }
}