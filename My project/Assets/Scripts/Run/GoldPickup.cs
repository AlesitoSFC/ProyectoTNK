using UnityEngine;

public class GoldPickup : MonoBehaviour
{
    public int amount = 1;
    void Start()
{
    Debug.Log("Oro instanciado");
}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory.instance.AddGold(amount);
            Destroy(gameObject);
        }
    }
}