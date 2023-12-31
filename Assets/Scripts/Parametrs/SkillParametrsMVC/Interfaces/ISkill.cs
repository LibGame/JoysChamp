﻿using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.SkillParametrsMVC.Interfaces
{

    public interface ISkill
    {
        int Percent { get; }
        SkillTypes Type { get; }

        void IncreasePercet(int count);
        void DecreasePercet(int count);
        void SetPercent(int percent);

        event Action<SkillTypes, int> OnChangeSkill;
    }
}