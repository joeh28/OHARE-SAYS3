using UnityEngine;

public class IdleTimer : MonoBehaviour
{
    private static IdleTimer instance;

    private float currentTime = 0f;

    private float startingTime = 40f;

    private bool timesUp = false;

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

    [System.Obsolete]
    private void Update()
    {
        if (!timesUp)
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                Debug.Log("Quit");
                Application.ExternalEval("window.location=\"http://www.flywithbutchohare.com\"");
                timesUp = true;
            }
            if (Input.touchCount > 0)
            {
                currentTime = startingTime;
                timesUp = false;
            }
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                currentTime = startingTime;
                timesUp = false;
            }
        }     
    }
}
