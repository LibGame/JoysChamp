using Assets.Scripts.PlayerMVC;
using Assets.Scripts.ScoreParametrsMVC;
using Assets.Scripts.ScoreParametrsMVC.Interfaces;
using Assets.Scripts.Screens.MenuScreen.Panels;
using Assets.Scripts.Screens.Panels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Screens.MenuScreen
{
    public class MenuScreen : Screen
    {
        [SerializeField] private List<Panel> _panels = new List<Panel>();

        [Inject] private ScoreParametrsController _scoreParametrsController;
        [Inject] private PlayerController _playerController;

        [Inject] private PlayerInfoPanel _playerInfoPanel;

        public override ScreenTypes ScreenTypes => ScreenTypes.Menu;

        private void Awake()
        {
            _panels.Add(_playerInfoPanel);
        }

        public override void OpenScreen()
        {
            _scoreParametrsController.Init(_playerController.GetScoreParametrModel());
            _playerInfoPanel.OpenScreen();
            base.OpenScreen();
        }
    }
}