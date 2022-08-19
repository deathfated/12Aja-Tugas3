using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Player
{
    public class PlayerView : BaseView
    {
        [SerializeField] private KeyCode leftKey;
        [SerializeField] private KeyCode rightKey;
        [SerializeField] private float speed;

        public int playerLives;

        private Rigidbody2D rig;
        private Vector2 resetPosition;

        public GameObject bulletFabs;

        [SerializeField] private GameObject GOPanel;

        void Start()
        {
            playerLives = 3;
            rig = GetComponent<Rigidbody2D>();
            resetPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        }

        private void Update()
        {
            MovePlayer(GetInput());
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
        }

        private void MovePlayer(Vector2 move)
        {
            rig.velocity = move;
        }

        private Vector2 GetInput()
        {
            if (Input.GetKey(leftKey))
            {
                return Vector2.left * speed;
            }
            if (Input.GetKey(rightKey))
            {
                return Vector2.right * speed;
            }
            return Vector2.zero;
        }

        void Fire()
        {
            Instantiate(bulletFabs, gameObject.transform.position, Quaternion.identity);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("bullet"))
            {
                /*if (playerLives <= 0)
                {
                    GOPanel.SetActive(true);
                }
                else*/ Dead();
            }
        }

        void Dead()
        {
            gameObject.transform.position = resetPosition;
            gameObject.SetActive(false);

            playerLives -= 1;
            //GameController.OnDecreaseLives();

            if (playerLives > 0)
            {
                Invoke(nameof(Respawn), 5.0f);
            }
            else GOPanel.SetActive(true);
        }

        void Respawn()
        {
            gameObject.SetActive(true);
        }
    }
}
