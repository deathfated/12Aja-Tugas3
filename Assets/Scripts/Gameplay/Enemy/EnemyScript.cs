using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay.Character
{
    public class EnemyScript : EnemyBase
    {
        [SerializeField]
        private float speedEnemy, damageEnemy, frontEnemy1, frontEnemy2, frontEnemy3, frontEnemy4;


        void Start()
        {
            SetSpeed();
        }

        void Update()
        {
            Move();
        }
        private void SetSpeed()
        {
            setSpeed(speedEnemy);
        }
    }
}

