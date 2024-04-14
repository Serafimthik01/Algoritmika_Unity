using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;

    void Update()
    {
        healthText.text = Corn.singleton.health.ToString();
    }
}

