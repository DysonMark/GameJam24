using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PortalFuture")
        {
            Debug.Log("Im here");
            SceneManager.LoadScene(3);
        }
    }
}
