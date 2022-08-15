using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Aja.Leaderboard
{
    public class LbView : BaseSceneView
    {
        [SerializeField] private Button _backButton;

        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(onClickPlayButton);
        }
    }
}