using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameFirstScene : MonoBehaviour
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
        SceneManager.LoadScene(2);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
