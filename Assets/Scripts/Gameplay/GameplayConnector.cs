using Agate.MVC.Base;
using Aja.Game;
using Aja.Message;
using Aja.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        protected override void Connect()
        {
            Subscribe<UpdateLivesMessage>(OnUpdateLives);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateLivesMessage>(OnUpdateLives);
        }

        private SaveDataController _saveData;
        private LivesController _lives;

        public void OnUpdateLives(UpdateLivesMessage message)
        {
            _saveData.OnUpdateLives(message.Lives);
            _lives.OnUpdateLives();
        }

    }
}