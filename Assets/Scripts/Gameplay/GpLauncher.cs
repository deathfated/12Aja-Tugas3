using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using Aja.Game;
using Aja.Soundfx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class GpLauncher : SceneLauncher<GpLauncher, GpView>
    {
        public override string SceneName => "Gameplay";
        private GameController _game;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new GameController(),
                new SoundfxController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _game.SetView(_view.GameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}