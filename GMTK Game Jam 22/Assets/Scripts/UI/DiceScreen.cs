using UnityEngine.UI;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class DiceScreen : MonoBehaviour
    {
        [SerializeField] GameObject StartButton;
        [SerializeField] GameObject RollButton;
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 0;
        }
        public void ShowStartButton()
        {
            RollButton.SetActive(false);
            StartButton.SetActive(true);
        }
        public void StartGame()
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}
