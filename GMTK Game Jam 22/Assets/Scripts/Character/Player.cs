using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RadiantGames.RandomBullets
{
    public class Player : Character
    {
        // Start is called before the first frame update
        void Start()
        {
            InitializeStats(8, 100);
        }
        
        public override void Die()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        void FixedUpdate()
        {
            MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") ));
            LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
