using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class Enemy : Character
    {
        [SerializeField] int FollowLimit = 12;
        [SerializeField] int DamagePerFrame = 1;
        GameObject Player;
        
        // Start is called before the first frame update
        void Start()
        {
            InitializeStats(10, 100);
            Player = GameObject.FindGameObjectWithTag("Player");
        }
        

        // Update is called once per frame
        void FixedUpdate()
        {
            if(Vector2.Distance(transform.position,Player.transform.position) > FollowLimit) { return; }
            LookAt(Player.transform.position);
            transform.position = Vector2.MoveTowards((Vector2)transform.position, (Vector2)Player.transform.position, Speed * Time.deltaTime);
        }

        void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Player.GetComponent<Player>().TakeDamage(DamagePerFrame);
            }
        }

        public override void Die()
        {
            AudioManager.PlaySound(AudioManager.Instance.AudioList[1]);
            base.Die();
        }
    }
}
