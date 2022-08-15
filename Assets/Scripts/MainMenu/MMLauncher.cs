using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.MainMenu
{
    public class MMLauncher : SceneLauncher<MMLauncher, MMView>
    {

        public override string SceneName => "MainMenu";


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
            _view.SetCallbacks(OnClickPlayButton);
            //_view.SetCallbacks(OnClickLeaderboardButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("NameInput");
        }

        private void OnClickLeaderboardButton()
        {
            SceneLoader.Instance.LoadScene("Leaderboard");
        }
    }
}