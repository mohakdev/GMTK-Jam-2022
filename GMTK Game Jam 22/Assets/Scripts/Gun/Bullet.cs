using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] GameObject bulletParticle;
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<Enemy>().TakeDamage(50);
                
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
                Instantiate(bulletParticle, transform.position, transform.rotation).SetActive(true);
            }
        }
    }
}
