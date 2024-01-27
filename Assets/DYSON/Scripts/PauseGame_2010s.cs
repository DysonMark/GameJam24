using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame_2010s : MonoBehaviour
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
        Debug.Log("Button was pressed");
        SceneManager.LoadScene(3);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
