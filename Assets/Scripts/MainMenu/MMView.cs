using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Aja.MainMenu
{
    public class MMView : BaseSceneView
    {
        [SerializeField] private Button _playButton;

        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}