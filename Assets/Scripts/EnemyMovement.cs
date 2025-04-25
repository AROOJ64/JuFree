using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float stoppingDistance;
    
    private Animator animator;
    private Transform playerTransform;
    private bool facingRight;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if (playerTransform == null) return;

        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        animator.SetBool("Run", distanceToPlayer > stoppingDistance);

        if (distanceToPlayer <= stoppingDistance) return;

        Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
        bool oppositeDirection = (directionToPlayer.x < 0 && !facingRight) || (directionToPlayer.x > 0 && facingRight);

        if (oppositeDirection) Flip();

        //transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        Vector3 newPosition = transform.position + new Vector3(directionToPlayer.x * speed * Time.deltaTime, 0, 0);
        transform.position = newPosition;
    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("attack", true);
            PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
            player.TakeDamage(10f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("attack", false);
        }
    }

    internal void SetPlayerPosition(Transform player)
    {
        playerTransform = player;
    }
}
