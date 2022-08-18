using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Aja.Game
{
    public class GameView : ObjectView<IGameModel>
    {
        [SerializeField] private Text _scoreText;
        [SerializeField] private Text _nameText;


        [SerializeField] private Button _gameOverButton;

        protected override void InitRenderModel(IGameModel model)
        {
            _scoreText.text = $"{model.Score.ToString()}";
            _nameText.text = PlayerPrefs.GetString("playerName"); // $"{model.Name}";
        }

        protected override void UpdateRenderModel(IGameModel model)
        {
            _scoreText.text = $"{model.Score.ToString()}";
        }

        public void SetCallbacks(UnityAction onClickGameOver)
        {
            _gameOverButton.onClick.RemoveAllListeners();
            _gameOverButton.onClick.AddListener(onClickGameOver);
        }
    }
}