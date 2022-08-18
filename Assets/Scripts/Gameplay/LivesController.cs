using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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