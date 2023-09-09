using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets.Scripts.Screens.CreateCharacterScreen
{
    public class CreateCharacterScreen : Screen
    {
        [SerializeField] private Button _nextButton;

        [Inject] private ScreenContext _screenContext;

        public override ScreenTypes ScreenTypes => ScreenTypes.Create_Character;

        private void Awake()
        {
            _nextButton.onClick.AddListener(OpenMenuScreen);
        }

        public void OpenMenuScreen()
        {
            _screenContext.OpenSreenByType(ScreenTypes.Menu);
        }
    }
}