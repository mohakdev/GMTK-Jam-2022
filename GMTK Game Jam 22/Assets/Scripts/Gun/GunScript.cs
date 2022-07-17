using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class GunScript : MonoBehaviour
    {
        Rigidbody2D Playerbody; //For Knockback effect
        
        [SerializeField] Transform ShootingPoint;
        [SerializeField] GameObject BulletPrefab;
        [SerializeField] int BulletVelocity = 10;
        [SerializeField] int KnockbackIntensity = 250;
        public int Ammo = 6;

        void Start()
        {
            Playerbody = GetComponent<Rigidbody2D>();
            ResetAmmo();
        }
        public void AddAmmo(int number)
        {
            Ammo += number;
            print(Ammo);
        }
        void ResetAmmo()
        {
            Ammo = 0;
        }

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

            BulletRbody.velocity = transform.right * BulletVelocity;
            KnockbackEffect();
            Ammo -= 1;
        }

        void KnockbackEffect()
        {
            Playerbody.AddRelativeForce(KnockbackIntensity * Vector2.left);
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
