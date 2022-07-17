using UnityEngine;
using UnityEngine.SceneManagement;

namespace RadiantGames.RandomBullets
{
    public class MenuScript : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
