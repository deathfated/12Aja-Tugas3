using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using Aja.Game;
using Aja.Score;
using Aja.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class GpLauncher : SceneLauncher<GpLauncher, GpView>
    {
        public override string SceneName => "Gameplay";
        private GameController _game;
        private PlayerController _player;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector(),
                new ScoreConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new LivesController(),
                new ScoreController(),
                new GameController(),
                new PlayerController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _player.SetView(_view.PlayerView);
            _game.SetView(_view.GameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}