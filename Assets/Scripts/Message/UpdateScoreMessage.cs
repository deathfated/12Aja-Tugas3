using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Message
{
    public struct UpdateScoreMessage
    {
        public int Score { get; private set; }

        public UpdateScoreMessage(int score)
        {
            Score = score;
        }
    }
}