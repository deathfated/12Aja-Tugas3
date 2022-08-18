using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class PowerUp : MonoBehaviour
    {
        [SerializeField] float spawnDelay;
        
        private void Awake()
        {
            Invoke(nameof(Respawn), spawnDelay);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("powerup triggered");
                //set bullet hp = 2

                gameObject.SetActive(false);

                Invoke(nameof(Respawn), 15.0f);
            }
        }

        private void Update()
        {
            Invoke(nameof(Despawn), 20.0f);
        }

        private void Respawn()
        {
            gameObject.SetActive(true);
        }

        private void Despawn()
        {
            gameObject.SetActive(false);
        }
    }
}