using Agate.MVC.Base;
using Aja.Boot;
using Aja.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Game
{
    public class GameController : ObjectController<GameController, GameModel, IGameModel, GameView>
    {
        private void OnClickGameOver()
        {
            SceneLoader.Instance.LoadScene("Leaderboard");
        }

        public override void SetView(GameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickGameOver);
        }

        private void OnAddScore(int skor)
        {
            _model.AddScore(skor);
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }


    }
}