using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RadiantGames.RandomBullets
{
    public class HealthBarScript : MonoBehaviour
    {
        Player PlayerScript;
        Slider HealthSlider;
        void Start()
        {
            PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            HealthSlider = gameObject.GetComponent<Slider>();
        }
        void Update()
        {
            HealthSlider.value = PlayerScript.Health;
        }
    }
}
