using Agate.MVC.Base;
using Aja.Message;
using Aja.Soundfx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SoundfxController _soundfx;
        //private SaveDataController _saveData;

        protected override void Connect()
        {
            Subscribe<UpdateScoreMessage>(OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateScoreMessage>(OnUpdateScore);
        }

        public void OnUpdateScore(UpdateScoreMessage message)
        {
            _soundfx.OnUpdateScore();
        }
    }
}