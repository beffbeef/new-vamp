using System.Collections;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{

    [SerializeField] private GameObject enemy1Prefab;
    [SerializeField] private GameObject enemy2Prefab;
    [SerializeField] private GameObject enemy3Prefab;

    [SerializeField] private float enemy1Interval = 4f;

    [SerializeField] private float enemy2Interval = 10f;

    [SerializeField] private float enemy3Interval = 15f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1Prefab));
        StartCoroutine(spawnEnemy(enemy2Interval, enemy2Prefab));
        StartCoroutine(spawnEnemy(enemy3Interval, enemy3Prefab));

        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
