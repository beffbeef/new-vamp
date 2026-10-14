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
        Health = Health - damage;
        Debug.Log("Player health: " + Health);

       
    }

    private void Update()
    {
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();

            Debug.Log("Dead");
        }
    }

}
