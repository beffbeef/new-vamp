using UnityEngine;


public class health : MonoBehaviour
{

    [Header("Health Settings")]
    public int Health = 100;
    private int currentHealth;

    private bool isDead;

    public GameManager gameManager;
    
    
    
    
    void Start()
    {
        currentHealth = Health;
    }

    
    
    
    public void TakeDamage(int damage)
    {
        if (isDead) return; 

        currentHealth -= damage;

        Debug.Log("Player health: " + currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }
       
    }

   
    
    private void Die()
    {
        isDead = true;
        
        Debug.Log("Dead");

       
        if (gameManager != null) 
        {
            gameManager.gameOver();

        }
        
       
    }

}
