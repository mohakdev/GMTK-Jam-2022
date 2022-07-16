using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class Player : Character
    {
        // Start is called before the first frame update
        void Start()
        {
            InitializeStats(8, 100);
        }

        void FixedUpdate()
        {
            MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") ));
            LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
