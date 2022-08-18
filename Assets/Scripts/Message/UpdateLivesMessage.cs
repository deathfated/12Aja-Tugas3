using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Message
{
    public struct UpdateLivesMessage
    {
        public int Lives { get; private set; }

        public UpdateLivesMessage(int lives)
        {
            Lives = lives;
        }
    }
}