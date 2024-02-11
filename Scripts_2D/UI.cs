using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
using System;

public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI textMeshProUGUI;

    public GameObject defeatUI;

    void Start()
    {
        textMeshProUGUI.text = player.points.ToString();
    }

    void Update()
    {
        if(player == null)
        {
            defeatUI.SetActive(true);
        }
    }

    void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
