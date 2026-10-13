
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 1f;

    void Update()
    {
        if (Mouse.current == null)
        {
            return;
        }

        Vector3 mousePosition = Mouse.current.position.ReadValue();

        mousePosition.z = -Camera.main.transform.position.z;

        Vector3 aimPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 aimDirection = aimPosition - firePoint.position;

        float angle = Mathf.Atan2(
            aimDirection.y,
            aimDirection.x
        ) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, angle);

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject bullet = Instantiate(
                bulletPrefab,
                firePoint.position,
                Quaternion.Euler(0, 0, angle)
            );

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            rb.linearVelocity = aimDirection.normalized * bulletSpeed;
        }
    }
}
