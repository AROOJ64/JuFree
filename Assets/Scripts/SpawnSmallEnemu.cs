using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSmallEnemu : MonoBehaviour
{
    public Transform spawningPoint;
    public GameObject smallPrefab;
    public GameObject playerPosition;
    [SerializeField] private float minSpawnInterval;
    [SerializeField] private float maxSpawnInterval;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            GameObject enemy = Instantiate(smallPrefab, spawningPoint.position, spawningPoint.rotation);
            EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
            enemyMovement?.SetPlayerPosition(playerPosition.transform);

            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
