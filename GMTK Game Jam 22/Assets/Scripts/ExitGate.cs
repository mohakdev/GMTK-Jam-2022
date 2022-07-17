using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace RadiantGames.RandomBullets
{
    public class ExitGate : MonoBehaviour
    {
        [SerializeField] GameObject GameCompleteLabel;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                int NextLevel = SceneManager.GetActiveScene().buildIndex + 1;
                if (SceneManager.sceneCountInBuildSettings <= NextLevel)
                {
                    GameCompleteLabel.SetActive(true);
                    Debug.Log("Ha");
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    Debug.Log("Hahah");

                }
            }
        }
    }
}
