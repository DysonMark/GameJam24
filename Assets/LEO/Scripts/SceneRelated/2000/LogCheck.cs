using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCheck : MonoBehaviour
{
    public int logCount;
    [SerializeField] GameObject portalPrefab;
    [SerializeField] Transform portalPos;

    private void Start()
    {
        logCount = 0;
    }

    private void Update()
    {
        if (logCount == 10)
        {
            Instantiate(portalPrefab, portalPos.position, Quaternion.identity);
            logCount++;
        }
    }
}
