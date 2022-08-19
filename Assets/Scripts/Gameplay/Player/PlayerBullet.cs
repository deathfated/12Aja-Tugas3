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
        public bool Powered;

        public GameObject Powerup;

        //int _score;

        void Start()
        {
            enemyParent = GameObject.Find("ENEMY");
            Powerup = GameObject.Find("PU1");
            Powered = false;
            Invoke("PowerUpSpawn", 5.0f);
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
                if (Powered == true)
                {
                    Destroy(gameObject, 0.5f);
                }
                else
                {
                    Destroy(gameObject);
                }
                //ScoreManager.PlayerScored();
            }

            if (collision.gameObject.CompareTag("power"))
            {
                Powered = true;
                Powerup.SetActive(false);

                Invoke("PowerUpSpawn", 5.0f);
                Invoke("PowerUpDespawn", 5.0f);
            }
        }

        private void PowerUpDespawn()
        {
            Powered = false;
        }

        private void PowerUpSpawn()
        {
            Powerup.SetActive(true);
        }
    }
}