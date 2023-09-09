using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Screens
{
    public class ScreenContext : MonoBehaviour
    {
        [SerializeField] private List<Screen> _screens;
        private Screen _currentScreen;

        
        private bool TryGetScreenByType(out Screen screen , ScreenTypes screenTypes)
        {
            screen = _screens.FirstOrDefault(x => x.ScreenTypes == screenTypes);
            if (screen != null)
            {
                return true;
            }
            return false;
        }

        public void OpenSreenByType(ScreenTypes screenType)
        {
            if(TryGetScreenByType(out Screen screen, screenType))
            {
                if (_currentScreen != null)
                    _currentScreen.CloseScreen();
                _currentScreen = screen;
                _currentScreen.OpenScreen();
            }
        }

    }
}