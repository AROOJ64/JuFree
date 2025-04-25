using UnityEngine;

public class PlayerMovement_Freedom : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private Animator anim;
    private SpriteRenderer sprite;

    //[SerializeField] private PolygonCollider2D _polygonCollider;

    public float movementSpeed = 5f;
    public float jumpingForce = 7f;
    public float gravityScale = 2f;
    //private bool isJumping = false;
    private enum MovementState { idel, running, faling, jumping }
    MovementState playerState;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = gravityScale;
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        //_polygonCollider.enabled = false;

        //if (_polygonCollider != null)
        //    _polygonCollider.enabled = false;
        //else
        //    Debug.LogError("Polygon Collider is not assigned to the PlayerMovement script!");

    }

    private void Update()
    {
        Movement();
        jump();

        //attack();

        //if(_rigidbody.velocity.y==0)
        //{
        //    isJumping = true;
        //}
        //else
        //{
        //    isJumping = false;
        //}
    }
    private void Movement()
    {
        float dirX = 0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1f;

            playerState = MovementState.running;

            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y = 0;
            transform.eulerAngles = currentRotation;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1f;

            playerState = MovementState.running;

            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y = 180f;
            transform.eulerAngles = currentRotation;
        }
        else
        {
            playerState = MovementState.idel;
        }

        _rigidbody.velocity = new Vector2(dirX * movementSpeed, _rigidbody.velocity.y);

        UpdateAnimation();
    }
    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) /*&& isJumping == true*/)
        {
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, jumpingForce, 0f);
        }
        if (_rigidbody.velocity.y > 0.1f)
        {
            playerState = MovementState.jumping;
        }
        else if (_rigidbody.velocity.y < -0.1f)
        {
            playerState = MovementState.faling;
        }
        UpdateAnimation();
    }
    //private void attack()
    //{
    //    if (Input.GetKey(KeyCode.E))
    //    {
    //        _polygonCollider.enabled = true;
    //        playerState = MovementState.attack;
    //    }
    //    else
    //    {
    //        _polygonCollider.enabled = false;
    //    }
    //    UpdateAnimation();
    //}
    private void UpdateAnimation()
    {
        int stateValue = (int)playerState;
        anim.SetInteger("state", stateValue);
    }

}
