using System.Collections;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _arrowPrefab;
    [SerializeField] private GameObject _spawner;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float maxSpawnDelay = 4f;
    [SerializeField] private float minSpawnDelay = 1f;
    private bool canSpawn = true;
    void Start()
    {
        StartCoroutine(spawnPrefab());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canSpawn = false;
        }
    }
    IEnumerator spawnPrefab()
    {
        while (canSpawn)
        {
            GameObject arrow = Instantiate(_arrowPrefab, _spawner.transform.position, Quaternion.identity);
            Rigidbody2D arrowRigidbody = arrow.GetComponent<Rigidbody2D>();
            arrowRigidbody.velocity = transform.right * speed;
            float waitTime = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(waitTime);
            StartCoroutine(spawnPrefab());
        }

    }
}
