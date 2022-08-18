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

        public AudioClip death;
        AudioSource audioSource;

        public bool PowerupOn;

        //int _score;

        void Start()
        {
            enemyParent = GameObject.Find("ENEMY");
            audioSource = GetComponent<AudioSource>();
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
                audioSource.PlayOneShot(death, 0.7F);
                //ScoreManager.PlayerScored();

                EnemyFire enemyfire = enemyParent.GetComponent<EnemyFire>();
                enemyfire.swapAttack(collision.gameObject);

                if (PowerupOn)
                Destroy(gameObject, 0.01f);
            }
        }
    }
}