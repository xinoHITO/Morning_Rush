using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameTimer : MonoBehaviour
{
    public TMP_Text Timer;
    public float TimeLimit = 20;

    public UnityEvent OnTimeOut;

    private float seconds = 0;
    private float miliseconds = 0;

    private void Start()
    {
        seconds = TimeLimit;
    }

    void Update()
    {
        if (miliseconds <= 0)
        {
            if (seconds <= 0)
            {
                OnTimeOut?.Invoke();
            }
            else if (seconds >= 0)
            {
                seconds--;
            }

            miliseconds = 100;
        }

        miliseconds -= Time.deltaTime * 100;
        miliseconds = Mathf.Max(0, miliseconds);

        string secondsString = "" + seconds;
        if (seconds < 10)
        {
            secondsString = "0" + seconds;
        }

        string milisecondsString = "" + (int)miliseconds;
        if (miliseconds < 10)
        {
            milisecondsString = "0" + (int)miliseconds;
        }

        //Debug.Log(string.Format("00:{0}:{1}", secondsString, milisecondsString));
        Timer.text = string.Format("00:{0}:{1}", secondsString, milisecondsString);

    }
}
