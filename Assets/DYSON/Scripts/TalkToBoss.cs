using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkToBoss : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public GameObject activeText;

    void Start()
    {
        uiText.enabled = false;
        activeText.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.tag == "Player")
        {
            uiText.enabled = true;
            activeText.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            uiText.enabled = false;
            activeText.SetActive(false);
        }
    }
}
