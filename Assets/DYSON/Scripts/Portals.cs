using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    [SerializeField] GameObject transitionObj;
    [SerializeField] AudioClip portalSFX;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "PortalPast")
        {
            audioSource.PlayOneShot(portalSFX);
            Debug.Log("Im here");
            Destroy(gameObject);    
            SceneManager.LoadScene(3);
        }
        else if (other.tag == "Player" && tag == "PortalFuture")
        {
            audioSource.PlayOneShot(portalSFX);
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
        else if (other.tag == "Player" && tag == "NewPortal")
        {
            StartCoroutine(TransitionToNextScene());
            
        }
    }

    IEnumerator TransitionToNextScene()
    {
        GameObject go = Instantiate(transitionObj, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position, Quaternion.identity);
        go.GetComponent<Animator>().SetBool("Transition", true);
        audioSource.PlayOneShot(portalSFX);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
}
