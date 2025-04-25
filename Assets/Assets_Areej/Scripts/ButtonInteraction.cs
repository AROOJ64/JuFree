using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("DoorOpen");
            _animator.SetBool("CloseDoor", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("DoorClose");
            _animator.SetBool("CloseDoor", false);
        }
    }
}
