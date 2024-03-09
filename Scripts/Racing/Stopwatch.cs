using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public bool hasFinished;
    float minutes;
    float seconds;

    public TextMeshProUGUI stopwatch;

    void Update()
    {
        if (!hasFinished)
        {
            seconds += Time.deltaTime;
        }
        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
        int m = Mathf.RoundToInt(minutes);
        int s = Mathf.RoundToInt(seconds);

        stopwatch.text = $"{m}:{s}";
    }
}
