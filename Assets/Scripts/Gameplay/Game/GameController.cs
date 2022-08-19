using Agate.MVC.Base;
using Aja.Boot;
using Aja.Message;
using Aja.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Game
{
    public class GameController : ObjectController<GameController, GameModel, IGameModel, GameView>
    {
        private SaveDataController _saveData;
        
        private void OnClickGameOver()
        {
            SceneLoader.Instance.LoadScene("Leaderboard");
            Time.timeScale = 1;
        }

        public override void SetView(GameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickGameOver);
        }

        public void OnAddScore(int skor)
        {
            _model.AddScore(skor);
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }

        public void OnDecreaseLives()
        {
            _model.DecreaseLives();
            Publish<UpdateLivesMessage>(new UpdateLivesMessage(_model.Lives));
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }
        public override IEnumerator Finalize()
        {
           yield return base.Finalize();
            _model.SetLives(_saveData.Model.Lives);
        }
    }
}