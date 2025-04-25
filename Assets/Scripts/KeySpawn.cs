using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    [SerializeField] private GameObject keyPrefab;
   // private bool keySpawned = false;

    private void Start()
    {
        DestroyBigEnemy.OnEnemyDestroyed += SpawnKey;
    }

    private void OnDestroy()
    {
        DestroyBigEnemy.OnEnemyDestroyed -= SpawnKey;
    }

    private void SpawnKey(Vector3 position)
    {
       // Vector2 vector2 = new Vector2(position.x+10, position.y);

        Instantiate(keyPrefab, position, Quaternion.identity);
    }
}
