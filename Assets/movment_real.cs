using UnityEngine;

public class movment_real : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5f;

    private Vector2 movement;

    private Rigidbody2D rb;



    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
        
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set (InputManager.Movement.x, InputManager .Movement.y);

        rb.linearVelocity = movement * _moveSpeed;
    }
}
