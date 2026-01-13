using TMPro;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;

    void Update()
    {
        if (PlayerInventory.instance != null)
        {
            goldText.text = "Oro: " + PlayerInventory.instance.gold;
        }
    }
}
