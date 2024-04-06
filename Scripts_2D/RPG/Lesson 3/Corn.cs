using UnityEngine;

public class Corn : MonoBehaviour
{
    public int health;

    public static Corn singleton;

    private void Awake()
    {
        singleton = this;
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= 1;
        }
    }
}