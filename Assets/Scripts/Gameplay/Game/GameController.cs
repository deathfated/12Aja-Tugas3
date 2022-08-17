using Agate.MVC.Base;
using Aja.Boot;
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
    }
}