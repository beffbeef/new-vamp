using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100;
    private int currentHealth;

    public GameObject aimpointer;
    private bool isDead;

    public GameManager gameManager;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        healthBar.SetHealth(currentHealth);

        Debug.Log("Player health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        healthBar.SetHealth(currentHealth);
    }

    private void Die()
    {
        isDead = true;

        Debug.Log("Dead");

        if (gameManager != null)
        {
            gameManager.gameOver();

            if (aimpointer != null)
            {
                aimpointer.SetActive(false);
            }

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Restart()
    {
        PlayerLevel.newRun = true;

        Time.timeScale = 1f;

        SceneManager.LoadScene("Game");
    }
}