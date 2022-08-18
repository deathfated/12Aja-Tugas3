using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateScore()
        {
            Debug.Log("Play Sound fx");
        }
    }
}