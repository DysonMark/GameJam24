using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
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
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
        else if (other.tag == "Player" && tag == "NewPortal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            Destroy(gameObject);
        }
    }
}
