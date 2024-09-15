using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector3 m_moveDirection = Vector3.right;

    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] public float _jumpSpeed = 5f;
    [SerializeField] float _gravityDrag = .5f;
    Rigidbody2D _rb = default;
    bool _isGrounded = false;
    Animator _anim = default;
    SpriteRenderer _sprite = default;
    float _h = 0;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _h = Input.GetAxis("Horizontal");
        Vector2 velocity = _rb.velocity;

        if (Input.GetButton("Jump") && _isGrounded)
        {
            _isGrounded = false;
            velocity.y = _jumpSpeed;
        }
        else if (!Input.GetButton("Jump") && velocity.y > 0)
        {
            velocity.y *= _gravityDrag;
        }

        _rb.velocity = velocity;
    }

    void FixedUpdate()
    {
        _rb.AddForce(_h * _moveSpeed * Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGrounded = false;
    }
    private void LateUpdate()
    {
        if (_h != 0)
        {
            _sprite.flipX = (_h < 0);
        }

        if (_anim)
        {
            _anim.SetFloat("Speed x", Mathf.Abs(_rb.velocity.x));
            _anim.SetFloat("Speed y", _rb.velocity.y);
            _anim.SetBool("isGrounded", _isGrounded);
        }
    }
}
