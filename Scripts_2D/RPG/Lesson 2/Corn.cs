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
        health -= 1;
    }
}