using UnityEngine;
using System.Collections.Generic;

public class WeaponAuto : MonoBehaviour
{
    public float attackCooldown = 1f;

    float nextAttackTime = 0f;
    List<Collider2D> enemiesInRange = new List<Collider2D>();

    void Update()
    {
        if (Time.time < nextAttackTime) return;

        enemiesInRange.RemoveAll(e => e == null);

        if (enemiesInRange.Count == 0) return;

        Collider2D closestEnemy = GetClosestEnemy();
        if (closestEnemy == null) return;

        Enemy enemy = closestEnemy.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Die();
        }

        enemiesInRange.Remove(closestEnemy);
        nextAttackTime = Time.time + attackCooldown;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && !enemiesInRange.Contains(other))
        {
            enemiesInRange.Add(other);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange.Remove(other);
        }
    }

    Collider2D GetClosestEnemy()
    {
        Collider2D closest = null;
        float shortestDistance = Mathf.Infinity;

        foreach (Collider2D enemy in enemiesInRange)
        {
            if (enemy == null) continue;

            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closest = enemy;
            }
        }

        return closest;
    }
}
