using System.Collections;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC.Interfaces
{
    public interface ISkillParametrsView 
    {
        void HandleSkillUpdate(SkillTypes skillType, int percent);

        void UpdateBluntWeapon(int percent);

        void UpdateStabbingWeapon(int percent);

        void UpdateSlashingWeapon(int percent);

        void UpdateThrownWeapon(int percent);

        void UpdateMagicWeapon(int percent);

    }
}