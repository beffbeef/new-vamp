using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{

    public static Vector2 Movement;

    private PlayerInput playerInput;
    private InputAction moveAction;

    private void Awake()
    {

        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Move"];
        
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       Movement = moveAction.ReadValue<Vector2>();
      
    }
}
