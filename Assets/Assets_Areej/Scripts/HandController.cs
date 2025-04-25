using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private GameObject player;
    public bool doorOpen = false;
    public float distance;
    private void Update()
    {
        distance = player.transform.position.x - this.transform.position.x;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!doorOpen && distance > 0.2f)
            {
                doorOpen = true;
                this.transform.Rotate(new Vector3(0, 0, 90));
                _animator.SetBool("DoorOpen", doorOpen);
            }
            else if (doorOpen && distance < 0.2f)
            {
                doorOpen = false;
                this.transform.Rotate(new Vector3(0, 0, -90));
                _animator.SetBool("DoorOpen", doorOpen);
            }
        }
    }
}
