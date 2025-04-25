using UnityEngine;

public class DestroyBigEnemy : MonoBehaviour
{
    public delegate void EnemyDestroyed(Vector3 position);

    public static event EnemyDestroyed OnEnemyDestroyed;
    private bool collided;

    private void Start()
    {
        collided = false;
    }
    private void Update()
    {
        if(collided)
        {
            InvokeKey();
            Debug.Log("Update");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Debug.Log("collided" + gameObject.name);
            //Destroy(gameObject);
            collided=true;
            //OnEnemyDestroyed?.Invoke(transform.position);
        }
    }

    private void InvokeKey()
    {
        OnEnemyDestroyed?.Invoke(transform.position);
        Destroy(gameObject);
        collided = false;
        Debug.Log("In Func" + transform.name);
    }
}