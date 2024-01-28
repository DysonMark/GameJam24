using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossClown2010 : MonoBehaviour
{
    [SerializeField] GameObject textBubbleRoad;
    [SerializeField] GameObject textBubbleOtherside;

    [SerializeField] Animator bossClownUIAnimator;
    [SerializeField] AudioClip windowsxpSFX;
    AudioSource audioSource;
    public bool windowsXP = false;
    int iCount = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        textBubbleRoad.SetActive(false);
        textBubbleOtherside.SetActive(false);

        StartCoroutine(StartClownBossDialogue());
    }

    private void Update()
    {
        if (textBubbleOtherside.activeInHierarchy && iCount < 1)
        {
            audioSource.PlayOneShot(windowsxpSFX);
            iCount++;
        }
    }

    IEnumerator StartClownBossDialogue()
    {
        textBubbleRoad.SetActive(true);
        textBubbleOtherside.SetActive(false);

        yield return new WaitForSeconds(7f);


        textBubbleRoad.SetActive(false);
        textBubbleOtherside.SetActive(true);

        yield return new WaitForSeconds(7f);

        textBubbleRoad.SetActive(false);
        textBubbleOtherside.SetActive(false);
    }
}
