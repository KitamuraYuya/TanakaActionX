using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] public float _jumpSpeed = 5f;
    [SerializeField] float _gravityDrag = .5f;
    Rigidbody2D _rb = default;
    bool _isGrounded = false;
    Vector3 _initialPosition = default;
    List<ItemBase> _itemList = new List<ItemBase>();
    Animator _anim = default;
    SpriteRenderer _sprite = default;
    float _h = 0;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
        _initialPosition = this.transform.position;
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

        if (Input.GetButtonDown("Fire1"))
        {
            if (_itemList.Count > 0)
            {
                ItemBase item = _itemList[0];
                _itemList.RemoveAt(0);
                item.Activate();
                Destroy(item.gameObject);
            }
        }

        
        if (this.transform.position.y < -10)
        {
            this.transform.position = _initialPosition;
        }
    }

    public void GetItem(ItemBase item)
    {
        _itemList.Add(item);
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
            _anim.SetFloat("Speed x",Mathf.Abs(_rb.velocity.x));
            _anim.SetFloat("Speed y",_rb.velocity.y);
            _anim.SetBool("isGrounded", _isGrounded);
        }
    }
}
