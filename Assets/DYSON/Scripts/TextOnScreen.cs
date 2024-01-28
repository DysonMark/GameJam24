using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextOnScreen : MonoBehaviour
{
    public GameObject Ouga;
    public GameObject goodAnswer;
    public GameObject bgImage;
    public TextMeshProUGUI talking;

    private void Start()
    {
        Ouga.SetActive(false);
        goodAnswer.SetActive(false);
        talking.enabled = false;
        bgImage.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "Philosophy")
        {
            talking.enabled = true;
            Ouga.SetActive(true);
            goodAnswer.SetActive(true);
            bgImage.SetActive(true);
            Debug.Log("In");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        talking.enabled = false;
        goodAnswer.SetActive(false);
        Ouga.SetActive(false);
        bgImage.SetActive(false);
    }
}
