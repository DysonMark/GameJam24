using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    [SerializeField] GameObject pauseMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            pauseMenu.SetActive(true);
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
