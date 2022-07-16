using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class Character : MonoBehaviour
    {
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }
        public int Speed { get; private set; }

        public void MoveCharacter(Vector3 direction)
        {
            transform.position += Speed * Time.deltaTime * direction;
        }

        public void LookAt(Vector2 target)
        {
            //This is to make the player rotate according to mouse        
            Vector2 difference = target - (Vector2)transform.position;
            difference.Normalize();
            float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle );
        }
        public void TakeDamage(int Amount)
        {
            Health -= Amount;
            if (Health <= 0)
            {
                Die();
            }
        }
        /// <summary>
        /// Heals the Character
        /// </summary>
        /// <param name="percent">Percent of the player health to heal 100% would be complete health</param>
        public void Heal(int percent)
        {
            if (percent > 100)
            {
                Debug.LogWarning("Percent is greater than 100%");
                Health = MaxHealth;
            }
            else
            {
                Health += MaxHealth * percent / 100;
            }
        }
        public virtual void Die()
        {
            //Default Implementation of the method
            Destroy(gameObject);
        }
        public void ChangeSpeed(int NewSpeed)
        {
            Speed = NewSpeed;
        }

        /// <summary>
        /// This is kind of a constructor for the character.
        /// </summary>
        /// <param name="speed">Speed of the character</param>
        /// <param name="maxHealth">Max Health of the character</param>
        public void InitializeStats(int speed, int maxHealth)
        {
            Speed = speed;
            MaxHealth = maxHealth;
            Health = MaxHealth; //This is so that every character always starts with full health
        }
    }
}
