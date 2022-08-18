using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aja.Score
{   
    public class ScoreView : BaseView
    {
        [SerializeField] Text _scoreText;

        private void UpdateScoreText(string text)
        {
            _scoreText.text = text;
        }
    }
}