
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health = health - damage;

        Debug.Log("Enemy health: " + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
