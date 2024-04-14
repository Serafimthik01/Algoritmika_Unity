using UnityEngine;
using UnityEngine.UI;

public class CrystalUI : MonoBehaviour
{
    public Text crystalText;

    void Update()
    {
        crystalText.text = Corn.singleton.crystals.ToString();
    }
}
