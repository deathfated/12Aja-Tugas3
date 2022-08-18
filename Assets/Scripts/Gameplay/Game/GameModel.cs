using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Game
{
    public class GameModel : BaseModel, IGameModel
    {
        public int Score { get; private set; }
        public string Name { get; private set; }

        public void SetScore(int skor)
        {
            Score = skor;
            SetDataAsDirty();
        }

        public void AddScore(int score)
        {
            Score += score;
            SetDataAsDirty();
        }

        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }
    }
}