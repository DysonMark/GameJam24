using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisAfterSeconds : MonoBehaviour
{
    [SerializeField] float selfDestructionTime = 5f;


    void Start()
    {
        StartCoroutine(SelfDestructSequence(selfDestructionTime));
    }

    IEnumerator SelfDestructSequence(float selfDestructionTime)
    {
        yield return new WaitForSeconds(selfDestructionTime);
        Destroy(gameObject);
    }
}
