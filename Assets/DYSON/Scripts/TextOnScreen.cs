using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextOnScreen : MonoBehaviour
{
    public GameObject Ouga;
    public GameObject goodAnswer;
   // public GameObject firstOrder;
    public TextMeshProUGUI talking;
    //public TextMeshProUGUI firstOrder;
    //public GameObject danceObject;
    //public GameObject firstOrderObject;
    //public GameObject triangle;

    private void Start()
    {
        //danceOrder.enabled = false;
        //firstOrder.enabled = true;
        //danceObject.SetActive(false);
        //firstOrderObject.SetActive(true);
        Ouga.SetActive(false);
        goodAnswer.SetActive(false);
        talking.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "Philosophy")
        {
            talking.enabled = true;
            Ouga.SetActive(true);
            goodAnswer.SetActive(true);
            Debug.Log("In");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        talking.enabled = false;
        goodAnswer.SetActive(false);
        Ouga?.SetActive(false);
    }
}
