using Assets.Scripts.GameData.Interfaces;
using Assets.Scripts.PlayerMVC;
using Assets.Scripts.Screens.Panels;
using Assets.Scripts.SkillParametrsMVC;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Screens.MenuScreen.Panels
{
    public class PlayerInfoPanel : Panel
    {
        [Inject] private SkillParametrsController _skillParametrsController;
        [Inject] private PlayerController _playerController;


        public override void OpenScreen()
        {
            _skillParametrsController.Init(_playerController.GetSkillParametrsModel());
            base.OpenScreen();
        }

    }
}