using UnityEngine;

public class Hunt : MonoBehaviour
{

   
    public float speed;
    public Transform target;
    private float distance;

    private Rigidbody2D rb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        target = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target == null) return;

        
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        
        rb.linearVelocity = direction * speed;

    }
}
