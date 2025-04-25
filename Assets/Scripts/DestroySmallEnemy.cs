using UnityEngine;

public class DestroySmallEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            //Debug.Log("collided");
            Destroy(gameObject);
        }
    }
}
