using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject portalPrefab;
    [SerializeField] Transform  portalPos;
    [SerializeField] GameObject diamondSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(portalPrefab, portalPos.position, Quaternion.identity);
            Destroy(diamondSprite);
        }
    }
}
