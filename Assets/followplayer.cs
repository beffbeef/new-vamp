using UnityEngine;

public class followplayer : MonoBehaviour
{
    [SerializeField] Transform player;

    float offset = -10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, offset);
    }
}
