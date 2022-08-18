using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Lives { get; }
    }
}