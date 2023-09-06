using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.Interfaces
{
    public interface IGameStarter
    {
        event Action OnGameStarted;
    }
}