using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] public GameObject gameOverScreen;
    int sceneIndex;
    bool menuIsOpen = false;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void GameIsOver()
    {
        gameObject.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneIndex);
        gameObject.SetActive(false);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);

    }
}
