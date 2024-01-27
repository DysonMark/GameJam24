using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public GameObject triggerText;

    private void Start()
    {
        triggerText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            triggerText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggerText.SetActive(false);
    }
}
