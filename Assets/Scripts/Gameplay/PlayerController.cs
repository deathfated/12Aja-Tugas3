using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private KeyCode leftKey;
        [SerializeField] private KeyCode rightKey;
        [SerializeField] private float speed;

        private Rigidbody2D rig;

        public GameObject bulletFabs;

        private void Start()
        {
            rig = GetComponent<Rigidbody2D>();
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
    }
}
