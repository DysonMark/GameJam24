using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossClown2010 : MonoBehaviour
{
    [SerializeField] GameObject textBubbleRoad;
    [SerializeField] GameObject textBubbleOtherside;
    [SerializeField] Animator bossClownUIAnimator;

    private void Start()
    {
        textBubbleRoad.SetActive(false);
        textBubbleOtherside.SetActive(false);
        StartCoroutine(StartClownBossDialogue());
    }
    void Update()
    {
        
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
