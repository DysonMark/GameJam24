using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightGreenLightManager : MonoBehaviour
{
    [SerializeField] Animator lookGuyAnimator;
    public bool isLooking = false;
    int lookingInterval;
    GameObject playerGO;
    [SerializeField] GameObject explotionPrefab;
    [SerializeField] GameObject gameOverScreen;

    float timePassed;

    private void Start()
    {
        lookingInterval = Random.Range(5, 10);
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > lookingInterval)
        {
            StartCoroutine(LookingSequence());
            lookingInterval = Random.Range(8, 12);
            timePassed = 0;
        }
        if (Input.GetKey(KeyCode.A) && isLooking || Input.GetKey(KeyCode.D) && isLooking)
        {
            playerGO = GameObject.FindGameObjectWithTag("Player");
            Destroy(playerGO);
            Instantiate(explotionPrefab, playerGO.transform.position, Quaternion.identity);
            Instantiate(gameOverScreen, Vector2.zero, Quaternion.identity);
            
        }
    }

    IEnumerator LookingSequence()
    {
        lookGuyAnimator.SetBool("isLooking", true);
        yield return new WaitForSeconds(1.5f);
        isLooking = true;
        yield return new WaitForSeconds(Random.Range(3 ,5));
        isLooking = false;
        lookGuyAnimator.SetBool("isLooking", isLooking);
    }
}
