using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextOnScreen : MonoBehaviour
{
    //public GameObject danceOrder;
   // public GameObject firstOrder;
    public TextMeshProUGUI danceOrder;
    public TextMeshProUGUI firstOrder;
    public GameObject danceObject;
    public GameObject firstOrderObject;
    public GameObject triangle;

    private void Start()
    {
        danceOrder.enabled = false;
        firstOrder.enabled = true;
        danceObject.SetActive(false);
        firstOrderObject.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "DanceOrder")
        {
            firstOrderObject.SetActive(false);
            firstOrder.enabled = false;
            danceObject.SetActive(true);
            danceOrder.enabled = true;
        }
        else
        {
            firstOrderObject.SetActive(true);
            firstOrder.enabled = true;
            danceObject.SetActive(false);
            danceOrder.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        danceOrder.enabled = false;
        firstOrder.enabled = true;
    }
}
