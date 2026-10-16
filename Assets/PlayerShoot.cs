
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform aimPointer;

    public float bulletSpeed = 10f;
    public float fireRate = 0.8f;

    private float nextFireTime = 0f;

    void Start()
    {
        Cursor.visible = false;
    }

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

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        
        firePoint.rotation = Quaternion.Euler(0, 0, angle);

       
        if (aimPointer != null)
        {
            aimPointer.position = new Vector3(
                aimPosition.x,
                aimPosition.y,
                0f
            );
        }

        
        if (Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;

            GameObject bullet = Instantiate(
                bulletPrefab,
                firePoint.position,
                Quaternion.Euler(0, 0, angle)
            );

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.linearVelocity = aimDirection.normalized * bulletSpeed;
            }
            else
            {
                Debug.LogError("Bullet prefab is missing Rigidbody2D!");
            }
        }
    }
}
