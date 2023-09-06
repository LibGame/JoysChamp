using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameData.Interfaces
{
    public interface IScoreParametrsConfig
    {
        public int Health { get;}
        public int HealthMax { get;}

        public int Mana { get; }
        public int ManaMax { get; }

        public int Stamina { get; }
        public int StaminaMax { get; }

        public float Experience { get; }
        public int Money { get; }
        public float GloryPoints { get; }
        public int Moral { get; }
        public int Rating { get; }
    }
}