using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour
{
    [SerializeField] Rigidbody2D signRb;
    int iCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && iCount < 1)
        {
            signRb.gravityScale = 1;
            iCount++;
        }
    }
}
