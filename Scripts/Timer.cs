using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public float sec;


    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        sec = Mathf.Round(seconds);
        if (sec == 0 && minutes >= 1)
        {
            seconds += 59;
            minutes--;
        }
        else if (sec == 0 && minutes == 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        print(minutes+ ":" + sec);
    }
}
