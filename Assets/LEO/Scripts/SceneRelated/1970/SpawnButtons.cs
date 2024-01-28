using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtons : MonoBehaviour
{
    [SerializeField] GameObject buttonSpawnPos;
    [SerializeField] GameObject[] buttons = new GameObject[3];
    [SerializeField] float spawnIntervals = 5f;

    [SerializeField] GameObject portal;
    [SerializeField] Transform portalPos;

    float timePassed = 0f;
    float intervalsPassed;

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > spawnIntervals)
        {
            intervalsPassed++;
            if ( 1 <= intervalsPassed && intervalsPassed <= 10)
            {
                InstantiateButtons();
                timePassed = 0f;
            }
            else
            {
                Instantiate(portal, portalPos.position, Quaternion.identity);
            }

        }
    }

    public void InstantiateButtons()
    {
        GameObject buttonInstantiated = Instantiate(buttons[UnityEngine.Random.Range(0,buttons.Length)], buttonSpawnPos.transform.position, Quaternion.identity);
        ButtonBehavior instBehavior = buttonInstantiated.GetComponent<ButtonBehavior>();
        if (0 <= intervalsPassed && intervalsPassed < 3)
        {
            instBehavior.buttonHorizontalSpeed = -5f;
        }
        else if (3 <= intervalsPassed && intervalsPassed < 6)
        {
            instBehavior.buttonHorizontalSpeed = -8f;
        }
        else if (6 <= intervalsPassed && intervalsPassed < 9)
        {
            instBehavior.buttonHorizontalSpeed = -10f;
        }
        else if (intervalsPassed == 10)
        {
            instBehavior.buttonHorizontalSpeed = -15f;
        }

        //Add winning condition and losing condition

    }
}
