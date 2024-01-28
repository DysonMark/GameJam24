using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBehaviour : MonoBehaviour
{
    [SerializeField] float logHorizontalSpeed;
    float logRotationSpeed;
    [SerializeField] GameObject logVis;
    Rigidbody2D rb;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] LogCheck logCheck;

    [SerializeField] AudioClip explosionSFX;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        logRotationSpeed = logHorizontalSpeed * -100;
        rb.velocity = new Vector2(logHorizontalSpeed, rb.velocity.y);
        logVis.transform.Rotate(0, 0, logRotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            audioSource.PlayOneShot(explosionSFX);
            Instantiate(gameOverScreen, Vector2.zero, Quaternion.identity);
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("LogCheck"))
        {
            logCheck.logCount++;
            Debug.Log("A log has left");
        }
    }
}
