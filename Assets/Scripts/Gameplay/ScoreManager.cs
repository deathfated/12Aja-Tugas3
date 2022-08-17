using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class ScoreManager : MonoBehaviour
    {
        public int _currentScore;

        private void Start()
        {
            _currentScore = 0;
        }

        public void PlayerScored()
        {
            _currentScore += 10;
            //scoreText.text = $"{_score}";
            Debug.Log(_currentScore);
        }
    }
}