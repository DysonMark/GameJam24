using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    [SerializeField] Animator carAnim;
    [SerializeField] AudioClip carClip;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    int iCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && iCount<1) 
        {
            audioSource.PlayOneShot(carClip);
            carAnim.SetBool("isPassing", true);
            iCount++;
        }
    }
}
