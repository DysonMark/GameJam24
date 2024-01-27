using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    [SerializeField] LvlMan2010 LvlMan2010;             //  Reference to the level manager script
    [SerializeField] Animator CarAnimator;              //  Reference to the car animator, to activate the car animation OnTriggerEnter
    [SerializeField] Animator TrafficLightAnimator;     // Reference to the traffic light animator to turn it red

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
        CarAnimator.SetBool("IsPassing", true);
        LvlMan2010.ActivateCarSequence();
    }
}
