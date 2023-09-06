using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameLoop : MonoBehaviour
    {
        private Coroutine _gameLoop;

        public void StartGameLoop()
        {
            _gameLoop = StartCoroutine(Loop());
        }

        public void StopGameLoop()
        {
            if(_gameLoop != null )
                StopCoroutine(_gameLoop);
        }

        public IEnumerator Loop()
        {
            while (true)
            {

                yield return new WaitForSeconds(1f);
            }
        }
    }
}