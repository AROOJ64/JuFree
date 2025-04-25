
//using System.Collections;
//using UnityEngine;

//public class SpawnBigEnemy : MonoBehaviour
//{
//    public Transform spawningPoint;
//    public GameObject[] bigPrefab;//Rhods
//    public GameObject playerPosition;
//    [SerializeField] private float minSpawnInterval;
//    [SerializeField] private float maxSpawnInterval;
//    [SerializeField] private int numberOfEnemies;
//    [SerializeField] private float initialDelay;
//    int index;//Rhods
//    private void Start()
//    {
//        StartCoroutine(StartSpawning());
//        index = 0;
//    }

//    private IEnumerator StartSpawning()
//    {
//        yield return new WaitForSeconds(initialDelay);

//        StartCoroutine(SpawnEnemies());
//    }

//    private IEnumerator SpawnEnemies()
//    {
//        if(index != bigPrefab.Length || index <= bigPrefab.Length)
//         //for (int i = 0; i < numberOfEnemies; i++)
//        {
//            GameObject enemy = Instantiate(bigPrefab[index], spawningPoint.position, spawningPoint.rotation);//Rhods
//            EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
//            enemyMovement?.SetPlayerPosition(playerPosition.transform);
//            index++;//Rhods
//            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
//            yield return new WaitForSeconds(spawnInterval);
//            StartCoroutine(SpawnEnemies());
//        }
//    }
//}
using System.Collections;
using UnityEngine;

public class SpawnBigEnemy : MonoBehaviour
{
    public Transform spawningPoint;
    public GameObject bigPrefab;
    public GameObject playerPosition;
    [SerializeField] private float minSpawnInterval;
    [SerializeField] private float maxSpawnInterval;
    [SerializeField] private int numberOfEnemies;
    [SerializeField] private float initialDelay;

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(initialDelay);

        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject enemy = Instantiate(bigPrefab, spawningPoint.position, spawningPoint.rotation);
            EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
            enemyMovement?.SetPlayerPosition(playerPosition.transform);

            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
