using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

namespace Assets.Scripts.Screens.Panels
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _panelsItems;

        public event Action OnOpen;
        public event Action OnClose;

        public virtual void OpenScreen()
        {
            foreach (var panel in _panelsItems)
            {
                panel.SetActive(true);
            }
        }

        public virtual void CloseScreen()
        {
            foreach (var panel in _panelsItems)
            {
                panel.SetActive(true);
            }
        }
    }
}