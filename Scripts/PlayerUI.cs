using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
//��� ����  �����  ����. ����������
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public Timer timer;
    public TextMeshProUGUI timerText;

    void Update()
    {
        // ��������� �������� �������� ������
        healthSlider.value = player.health;

        // ��������� ����� � ���-��� �������
        coinsCounterText.text = player.coins.ToString();

        // ������� � ��������� ������
        string min = timer.minutes.ToString();
        string sec = timer.sec.ToString();
        timerText.text = $"{min}:{sec}";
    }

}
