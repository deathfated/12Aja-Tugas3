using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aja.NameInput
{
    public class NameInput : SceneLauncher<NameInput, NIView>
    {
        public string stringToEdit = "AAA";
        [SerializeField] private Text teks;

        public override string SceneName => "NameInput";

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
            _view.SetCallbacks(OnClickButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickButton()
        {
            PlayerPrefs.SetString("playerName", teks.text);
            // buat panggil nanti:
            //string a = playerpref.setstring("playerName");
            Debug.Log("Current Player Name: " + teks.text);

            SceneLoader.Instance.LoadScene("Gameplay");
        }

        private void OnGUI()
        {
            stringToEdit = GUI.TextField(new Rect(510, 360, 50, 20), stringToEdit, 3);
        }

        private void Update()
        {
            teks.text = stringToEdit;
        }
    }
}