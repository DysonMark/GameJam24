using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject gameOverScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Instantiate(gameOverScreen, Vector2.zero, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
