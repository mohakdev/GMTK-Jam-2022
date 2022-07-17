using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RadiantGames.RandomBullets
{
    public class Dice : MonoBehaviour
    {
        [SerializeField] Sprite[] DiceImages;
        [SerializeField] DiceScreen diceScreenScript;
        GunScript gunScript;
        // Start is called before the first frame update
        void Start()
        {
            gunScript = GameObject.FindGameObjectWithTag("Player").GetComponent<GunScript>();
        }
        public void RollDice()
        {
            int randomNumber = Random.Range(0, DiceImages.Length);
            GetComponent<Image>().sprite = DiceImages[randomNumber];
            int diceNumber = randomNumber + 1; //Because Index starts from zero and dice starts from 1
            gunScript.AddAmmo(diceNumber);
            diceScreenScript.ShowStartButton();
        }
    }
}
