using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int level = 1;

    private void Awake()
    {
        level = PlayerPrefs.GetInt("level", 1);
    }

    public static void SaveLevel()
    {
        PlayerPrefs.SetInt("level", level);
    }
    public static void SaveCrystals()
    {
        PlayerPrefs.SetInt("crystals", Corn.singleton.crystals);
    }

    public static void ClearCrystals()
    {
        PlayerPrefs.SetInt("crystals", 0);
    }
    public static void SaveHealthGrade()
    {
        PlayerPrefs.SetInt("healthGrade", UpgradeController.healthGrade);
    }

    public static void ClearHealthGrade()
    {
        PlayerPrefs.SetInt("healthGrade", 0);
    }

    public void ClearSave()
    {
        ClearLevel();
        ClearCrystals();
        ClearHealthGrade();
    }

    public static void ClearLevel()
    {
        PlayerPrefs.SetInt("level", 1);
    }


}
