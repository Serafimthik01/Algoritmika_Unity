using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
//мод дост  класс  назв. переменной
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public Timer timer;
    public TextMeshProUGUI timerText;

    void Update()
    {
        // Обновляем значение здоровья игрока
        healthSlider.value = player.health;

        // Обновляем текст с кол-вом монеток
        coinsCounterText.text = player.coins.ToString();

        // Выводим и обновляем таймер
        string min = timer.minutes.ToString();
        string sec = timer.sec.ToString();
        timerText.text = $"{min}:{sec}";
    }

}
