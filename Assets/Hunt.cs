using UnityEngine;

public class Hunt : MonoBehaviour
{

   
    public float speed;
    public Transform target;
    private float distance;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.position);
        Vector2 direction = target.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);

    }
}
