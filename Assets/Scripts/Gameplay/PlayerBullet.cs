using Aja.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aja.Gameplay
{
    public class PlayerBullet : BulletScript
    {
        public GameObject enemyParent;
        public Text scoreText;

        //int _score;

        void Start()
        {
            enemyParent = GameObject.Find("ENEMY");
            //_score = 0;
        }

        protected override void Update()
        {
            transform.Translate(speed * Time.deltaTime * Vector2.up);
            CheckBorder();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {
                EnemyFire enemyfire = enemyParent.GetComponent<EnemyFire>();
                enemyfire.swapAttack(collision.gameObject);
                Destroy(gameObject);

                //ScoreManager.PlayerScored();
            }
        }
    }
}