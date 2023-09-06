using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Interfaces
{
    public interface ISkillParametrsConfing
    {
        public int BluntWeapon { get; }
        public int StabbingWeapon { get; }
        public int SlashingWeapon { get; }
        public int ThrownWeapons { get; }
        public int Magic { get; }
    }
}