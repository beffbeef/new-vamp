
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    public float damageCooldown = 0.5f;
    
    public GameObject playerPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health player = collision.gameObject.GetComponent<health>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }

        
    }

  

    






}
