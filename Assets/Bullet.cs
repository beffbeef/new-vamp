
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 50;
    float lifetime = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
        if(collision.CompareTag("Enemy"))
        {


           if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);

            }

            
        }
    }

    private void Start()
    {
        Destroy(gameObject,lifetime);
    }
}

