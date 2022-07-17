using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class ParticleCollector : MonoBehaviour
    {
        [SerializeField] int SecondsToDelete; //Deletes the object after this number of seconds
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, SecondsToDelete);
        }
    }
}
