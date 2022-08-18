using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.SaveData
{ 
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public int Lives { get; private set; }
        public int Score { get; private set; }

        public void SetLivesData(int lives)
        {
            Lives = lives;
            SetDataAsDirty();
        }

        public void SetScoreData(int score)
        {
            Score = score;
            SetDataAsDirty();
        }
    }
}