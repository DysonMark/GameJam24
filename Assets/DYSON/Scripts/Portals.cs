using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    int currentScene;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "PortalPast")
        {
            Debug.Log("Im here");
            Destroy(gameObject);    
            SceneManager.LoadScene(3);
        }
        else if (other.tag == "Player" && tag == "PortalFuture")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
        else if (other.tag == "Player" && tag == "NewPortal")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(currentScene + 1); 
        }
    }
}
