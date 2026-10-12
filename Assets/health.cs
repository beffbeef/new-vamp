using UnityEngine;

public class health : MonoBehaviour
{

    [Header("Health Settings")]
    public float maxHealth = 100f;
    private float currentHealth;
    


    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log(gameObject.name + "took" + amount + "damage. Current health:" + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
