using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class GunScript : MonoBehaviour
    {
        [SerializeField] Transform ShootingPoint;
        [SerializeField] GameObject BulletPrefab;
        int Ammo = 6;

        void Update()
        {
            if (IsShooting()) 
            {
                Shoot();
            }
        }

        void Shoot()
        {
            if(Ammo <= 0) { return; }//If ammo is less than zero than we return
            GameObject Bullet = Instantiate(BulletPrefab, ShootingPoint.position, ShootingPoint.rotation);
            Rigidbody2D BulletRbody = Bullet.GetComponent<Rigidbody2D>();

            BulletRbody.velocity = transform.right * 10;
        }

        bool IsShooting()
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                return true;
            }
            return false;
        }
    }
}
