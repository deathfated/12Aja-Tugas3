using Agate.MVC.Base;
using Aja.Game;
using Aja.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerView>
    {
        private SaveDataController _saveData;
        private GameController _game;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _game.OnDecreaseLives();
        }
    }
}
