using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI text;

    void Update()
    {
        float number = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        text.text = number.ToString();
    }
}
