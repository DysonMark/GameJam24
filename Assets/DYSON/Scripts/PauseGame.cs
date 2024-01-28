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
        Time.timeScale = 1;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    [SerializeField] GameObject pauseMenu;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !menuIsOpen)
        {
            Debug.Log("Enter");     
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            menuIsOpen = true;
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && menuIsOpen)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
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
