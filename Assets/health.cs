using UnityEngine;

public class health : MonoBehaviour
{

    [Header("Health Settings")]
    public int Health = 100;
    private int currentHealth;
    


    void Start()
    {
        currentHealth = Health;
    }

    public void TakeDamage(int damage)
    {
        Health = Health - damage;
        Debug.Log("Player health: " + Health);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

   

    void Update()
    {
        
    }
}
