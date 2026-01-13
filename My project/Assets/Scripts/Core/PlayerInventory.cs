using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory instance;
    public int gold = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddGold(int amount)
    {
        gold += amount;
        Debug.Log("Oro actual: " + gold);
    }
}