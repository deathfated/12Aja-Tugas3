using Agate.MVC.Base;
using Agate.MVC.Core;
using Aja.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}