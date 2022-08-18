using Agate.MVC.Base;
using Aja.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aja.Game
{
    public class LivesController : BaseController<LivesController>
    {
        public void OnUpdateLives()
        {
            Debug.Log("UPDATE UI LIVES -1");
            //change display
        }
    }
}