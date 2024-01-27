using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] public float buttonHorizontalSpeed = -50;
    [SerializeField] GameObject explosionEffect;
    [SerializeField] GameObject gameOverScreen;

    Rigidbody2D rb;
    public bool wasPressed;

    void Start()
    {
        wasPressed = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(buttonHorizontalSpeed, rb.velocity.y);
        if (wasPressed)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Instantiate(gameOverScreen, Vector2.zero, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
