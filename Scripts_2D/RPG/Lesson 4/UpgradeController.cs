using UnityEngine;
using UnityEngine.UI;

public class UpgradeController : MonoBehaviour
{
    public int healthGradePrice;
    public static int healthGrade;

    public Text healthGradePriceText;

    private void Update()
    {
        healthGradePriceText.text = healthGradePrice.ToString();
    }

    public void OnClickUpgradeHealth()
    {
        if (Corn.singleton.crystals >= healthGradePrice)
        {
            healthGrade = PlayerPrefs.GetInt("healthGrade", 0);
            healthGrade += 1;
            GameController.SaveHealthGrade();

            Corn.singleton.DecCrystals(healthGradePrice);
        }
    }
}