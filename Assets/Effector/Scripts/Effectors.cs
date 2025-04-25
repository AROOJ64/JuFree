using UnityEngine;

public class Effectors : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    public bool doorOpen = false;
    public float distance;

    [SerializeField] BuoyancyEffector2D effector;

    private void Start()
    {
        effector.enabled = false;
    }
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
                effector.enabled = true;
            }
            else if (doorOpen && distance < 0.2f)
            {
                doorOpen = false;
                this.transform.Rotate(new Vector3(0, 0, -90));
                effector.enabled = false;
            }
        }
    }
}
