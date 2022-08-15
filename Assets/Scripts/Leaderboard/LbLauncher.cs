using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Leaderboard
{
    public class LbLauncher : SceneLauncher<LbLauncher, LbView>
    {
        public override string SceneName => "Leaderboard";
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickBackButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickBackButton()
        {
            SceneLoader.Instance.LoadScene("MainMenu");
        }
    }
}