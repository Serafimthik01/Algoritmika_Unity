using UnityEngine;

public class Corn : MonoBehaviour
{
    public int health;
    public int crystals;

    public int initHealth;
    public int healthPerUpgrade;

    public static Corn singleton;

    private void Awake()
    {
        singleton = this;
        crystals = PlayerPrefs.GetInt("crystals", 0);

        int healthBonus = healthPerUpgrade * PlayerPrefs.GetInt("healthGrade", 0);
        health = initHealth + healthBonus;
    }

    public void AddCrystals(int newCrystals)
    {
        crystals += newCrystals;
        GameController.SaveCrystals();
    }

    public void DecCrystals(int decCrystal)
    {
        crystals -= decCrystal;
        GameController.SaveCrystals();
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= 1;
        }
    }

}