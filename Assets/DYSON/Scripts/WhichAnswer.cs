using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichAnswer : MonoBehaviour
{
    public GameObject playerDestruction;
    public GameObject gameOverScreen;
    public GameObject portal;

    private void Start()
    {
        portal.SetActive(false);
    }
    public void OugaBoutton()
    {
        gameOverScreen.SetActive(true);
    }

    public void GoodAnswer()
    {
        portal.SetActive(true);
    }
}
