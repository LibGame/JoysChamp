using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Screens
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private GameObject[] _items;
        public virtual ScreenTypes ScreenTypes { get; private set; }

        public event Action OnOpen;
        public event Action OnClose;

        public virtual void OpenScreen()
        {
            foreach(var panel in _items)
            {
                panel.SetActive(true);
            }
        }

        public virtual void CloseScreen()
        {
            foreach (var panel in _items)
            {
                panel.SetActive(true);
            }
        }

    }
}