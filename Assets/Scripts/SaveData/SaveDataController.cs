using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        private void SaveData()
        {
            PlayerPrefs.SetInt("Lives", _model.Lives);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            int lives = PlayerPrefs.GetInt("Lives");
            _model.SetLivesData(lives);
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnUpdateLives(int lives)
        {
            _model.SetLivesData(lives);
            SaveData();
        }
    }
}