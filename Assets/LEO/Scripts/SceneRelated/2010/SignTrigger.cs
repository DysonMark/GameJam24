using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody2D signRb;
    [SerializeField] AudioClip signFallingSFX;
    AudioSource audioSource;

    int iCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && iCount < 1)
        {
            audioSource.PlayOneShot(signFallingSFX);
            signRb.gravityScale = 1;
            iCount++;
        }
    }
}
