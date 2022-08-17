using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Game
{
    public interface IGameModel : IBaseModel
    {
        public int Score { get; }
        public string Name { get; }
    }
}