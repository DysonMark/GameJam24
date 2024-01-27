using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

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
        SceneManager.LoadScene(2);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
