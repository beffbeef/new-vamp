using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    public float expReward = 3;

    public void TakeDamage(int damage)
    {
        health = health - damage;

        Debug.Log("Enemy health: " + health);

        if (health <= 0)
        {
            
            PlayerLevel player = FindAnyObjectByType<PlayerLevel>();
            if (player != null)
            {
                player.AddXP(expReward);
            }

            Destroy(gameObject);
            ScoreManager.instance.AddPoints();
        }

        
    }

    public void SpawnHealth()
    {
        
    }




}
