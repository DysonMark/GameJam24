using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    int sceneIndex;
    bool menuIsOpen = false;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    [SerializeField] GameObject pauseMenu;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !menuIsOpen)
        {
            pauseMenu.SetActive(true);
            menuIsOpen = true;
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && menuIsOpen)
        {
            pauseMenu.SetActive(false);
            menuIsOpen = false;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
