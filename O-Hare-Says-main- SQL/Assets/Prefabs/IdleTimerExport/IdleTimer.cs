using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleTimer : MonoBehaviour
{
    private static IdleTimer instance;

    private float currentTime = 0f;

    private float startingTime = 40f;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            Debug.Log("Quit");
            Application.ExternalEval("window.location=\"http://www.flywithbutchohare.com\"");
        }

        if (Input.touchCount > 0)
        {
            currentTime = startingTime;
        }
    }
}
