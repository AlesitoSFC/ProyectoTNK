using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;

    public TextMeshProUGUI healthText;

    bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        UpdateHealthText();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        Debug.Log("PLAYER MUERTO");
        StartCoroutine(ReturnToVillage());
    }

    IEnumerator ReturnToVillage()
    {
        yield return new WaitForSeconds(2f);
        GameManager.instance.ReturnToVillage();
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Vida: " + currentHealth;
        }
    }
}