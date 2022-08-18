using Agate.MVC.Base;
using Aja.Message;
using Aja.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Score
{
    public class ScoreConnector : BaseConnector
    {
        private ScoreController _score;
        private SaveDataController _savedata;
        
        public void OnUpdateScore(UpdateScoreMessage message)
        {
            _score.OnUpdateScore();
            _savedata.OnUpdateScore(message.Score);
        }

        protected override void Connect()
        {
            Subscribe<UpdateScoreMessage>(OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateScoreMessage>(OnUpdateScore);
        }
    }
}