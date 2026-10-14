
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health player = collision.gameObject.GetComponent<health>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
