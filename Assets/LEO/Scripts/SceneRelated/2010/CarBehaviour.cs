using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    [SerializeField] GameObject playerDeathExplosion;
    [SerializeField] GameObject gameOverScreen;
    int iCount;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && iCount<1)
        {
            Instantiate(playerDeathExplosion, collision.transform.position, Quaternion.identity);
            gameOverScreen.SetActive(true);
            Destroy(collision.gameObject);
            iCount++;
        }
    }
}
