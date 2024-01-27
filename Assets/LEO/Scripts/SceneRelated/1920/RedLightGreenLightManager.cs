using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightGreenLightManager : MonoBehaviour
{
    [SerializeField] Animator lookGuyAnimator;
    public bool isLooking = false;
    int lookingInterval;

    float timePassed;

    private void Start()
    {
        lookingInterval = Random.Range(3, 10);
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > lookingInterval)
        {
            StartCoroutine(LookingSequence());
            timePassed = 0;
        }
        if (Input.GetButton(KeyCode.A)) || (Input.GetButton(KeyCode.A)) || (Input.GetButton(KeyCode.A)) ||)
    }

    IEnumerator LookingSequence()
    {
        lookGuyAnimator.SetBool("isLooking", true);
        yield return new WaitForSeconds(1.5f);
        isLooking = true;
        yield return new WaitForSeconds(Random.Range(3 ,10));
        isLooking = false;
        lookGuyAnimator.SetBool("isLooking", false);
        lookingInterval = Random.Range(3, 10);
    }
}
