using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRingBehaviour : MonoBehaviour
{
    [SerializeField] AudioClip pressButtonSFX;
    AudioSource audioSource;

    SpriteRenderer spriteRenderer;
    bool inRangeZ = false;
    bool inRangeX = false;
    bool inRangeC = false;

    bool pressedZ = false;
    bool pressedX = false;
    bool pressedC = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && inRangeZ)
        {
            audioSource.PlayOneShot(pressButtonSFX);
            pressedZ = true;
            inRangeZ = false;
            StartCoroutine(GreenEffectFeedback(spriteRenderer));
        }
        if (Input.GetKeyDown(KeyCode.X) && inRangeX)
        {
            audioSource.PlayOneShot(pressButtonSFX);
            pressedX = true;
            inRangeX = false;
            StartCoroutine(GreenEffectFeedback(spriteRenderer));
        }
        if (Input.GetKeyDown(KeyCode.C) && inRangeC)
        {
            audioSource.PlayOneShot(pressButtonSFX);
            pressedC = true;
            inRangeC = false;
            StartCoroutine(GreenEffectFeedback(spriteRenderer));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ZButton"))
        {
            inRangeZ = true;
        }
        if (collision.gameObject.CompareTag("XButton"))
        {
            inRangeX = true;
        }
        if (collision.gameObject.CompareTag("CButton"))
        {
            inRangeC = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ZButton"))
        {
            if (pressedZ) // si presiono Z que se elimine the thing lol
            {
                pressedZ = false;
                ButtonBehavior buttonBehavior = collision.GetComponent<ButtonBehavior>();
                buttonBehavior.wasPressed = true;
            }
            else
            {
                StartCoroutine(RedEffectFeedback(spriteRenderer));
            }
        }
        if (collision.gameObject.CompareTag("XButton"))
        {
            if (pressedX)
            {
                pressedX = false;
                ButtonBehavior buttonBehavior = collision.GetComponent<ButtonBehavior>();
                buttonBehavior.wasPressed = true;
            }
            else
            {
                StartCoroutine(RedEffectFeedback(spriteRenderer));
            }
        }
        if (collision.gameObject.CompareTag("CButton"))
        {
            if (pressedC)
            {
                pressedC = false;
                ButtonBehavior buttonBehavior = collision.GetComponent<ButtonBehavior>();
                buttonBehavior.wasPressed = true;
            }
            else
            {
                StartCoroutine(RedEffectFeedback(spriteRenderer));
            }
        }
    }

    IEnumerator GreenEffectFeedback(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.green;
        yield return new WaitForSeconds(.2f);
        spriteRenderer.color = Color.white;
    }
    IEnumerator RedEffectFeedback(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(.3f);
        spriteRenderer.color = Color.white;
    }
}
