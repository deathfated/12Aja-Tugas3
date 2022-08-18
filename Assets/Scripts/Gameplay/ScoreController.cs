using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Score
{
    public class ScoreController : BaseController<ScoreController>
    {
        public void OnUpdateScore()
        {
            Debug.Log("Update Score + +");
        }
    }
}