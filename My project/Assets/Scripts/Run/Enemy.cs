using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public GameObject goldPrefab;

    Transform player;
    bool isDead = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null || isDead) return;

        Vector2 direction = (player.position - transform.position).normalized;
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isDead) return;

        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }
        }
    }

    public void Die()
{
    Debug.Log("Enemy.Die() llamado");
    if (isDead) return;

    isDead = true;
    DropGold();
    Destroy(gameObject);
}

    void DropGold()
{
    Debug.Log("DropGold() llamado");

    if (goldPrefab == null)
    {
        Debug.LogError("GoldPrefab es NULL");
        return;
    }

    GameObject gold = Instantiate(goldPrefab, transform.position, Quaternion.identity);
    Debug.Log("Gold instanciado: " + gold.name);
}
}
