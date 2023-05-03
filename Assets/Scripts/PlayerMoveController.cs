using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [Range(0.1f, 2)]
    public float moveSpeed = 1;

    [SerializeField]
    private Rigidbody2D rb;

    private Vector2 _moveInput;
    private Vector2 _moveDirection;

    private void HandleMovement()
    {
        _moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _moveDirection = _moveInput.normalized;
    }

    private void FixedUpdate()
    {
        HandleMovement();
        rb.velocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }
}
