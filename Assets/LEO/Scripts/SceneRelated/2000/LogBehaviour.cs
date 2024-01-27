using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBehaviour : MonoBehaviour
{
    [SerializeField] float logHorizontalSpeed;
    float logRotationSpeed;
    [SerializeField] GameObject logVis;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        logRotationSpeed = logHorizontalSpeed * -100;
        rb.velocity = new Vector2(logHorizontalSpeed, rb.velocity.y);
        logVis.transform.Rotate(0, 0, logRotationSpeed * Time.deltaTime);
    }
}
