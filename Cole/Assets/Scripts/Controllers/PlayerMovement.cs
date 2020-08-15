using UnityEngine;
public enum Direction
{
    Down,
    Up,
    Left,
    Right
}
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Direction lastDirection;
    private Rigidbody2D rb;
    private Animator anim;

    Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
