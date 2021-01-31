using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScore : MonoBehaviour
{
    public TMP_Text TimeLabel;

    // Start is called before the first frame update
    void Start()
    {
        float seconds = PlayerPrefs.GetFloat("GGJ221.Time.Seconds",99);
        float miliseconds = PlayerPrefs.GetFloat("GGJ221.Time.Miliseconds",99);
   
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

        TimeLabel.text = string.Format("Tu tiempo fue 00:{0}:{1}", secondsString, milisecondsString);
    }

}
