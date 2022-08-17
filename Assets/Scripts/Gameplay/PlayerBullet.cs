using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class PlayerBullet : BulletScript
    {
        public GameObject enemyParent;

        void Start()
        {
            enemyParent = GameObject.Find("ENEMY");
        }

        protected override void Update()
        {
            transform.Translate(speed * Time.deltaTime * Vector2.up);
            checkBorder();
        }

        /*public void checkBorder()
        {
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            if (screenPosition.y > Screen.width || screenPosition.y < 0)
            {
                Destroy(gameObject);
            }
        }*/

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {
                EnemyFire enemyfire = enemyParent.GetComponent<EnemyFire>();
                enemyfire.swapAttack(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}