using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;   
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            GameIsOver(currentHealth);
        }
    }
    public void GameIsOver(int currentHealth)
    {

    }
}
