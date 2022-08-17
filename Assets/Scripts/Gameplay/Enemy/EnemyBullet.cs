using Aja.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Enemy
{
    public class EnemyBullet : BulletScript
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                Debug.Log("HIT");

                //signal ship destroyed + life change
            }
        }

    }
}