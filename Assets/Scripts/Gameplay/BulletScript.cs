using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aja.Gameplay
{
    public abstract class BulletScript : MonoBehaviour
    {
        public float speed;

        protected virtual void Update()
        {
            transform.Translate(speed * Time.deltaTime * Vector2.down);
            checkBorder();
        }

        public void checkBorder()
        {
            Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            if (screenPosition.y > Screen.width || screenPosition.y < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}