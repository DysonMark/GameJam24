using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpike : MonoBehaviour
{
    public GameObject gameOverScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(gameOverScreen, Vector2.zero, Quaternion.identity);
        }
    }


}
