using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private surfaceSlider _surfaceSlider;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpDistance;
    [SerializeField] private float _gravityScale = 0.1f;
    [SerializeField] private float _mass = 1f;

    private Vector2 directionAlongSurface = Vector2.zero;
    private Vector2 offset;
    private bool _isGrounded = false;

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    public void Move(Vector2 direction)
    {
        if (_isGrounded)
        {
            directionAlongSurface = _surfaceSlider.Project(direction.normalized);  
        }
        else
        {
            directionAlongSurface = direction;
        }

        offset = directionAlongSurface * _speed;
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            //_isGrounded = false;
            _rigidbody.MovePosition(_rigidbody.position + new Vector2(0, _jumpDistance));
            //_rigidbody.AddForce(new Vector2(0, _jumpDistance), ForceMode2D.Impulse);
        }
    }

    private void Update()
    {
        if (_isGrounded)
        {
            
        }
        else
        {
            //Fall(-new Vector2(0, 1));
        }
    }

    private Vector2 Fall(Vector2 direction)
    {
        return new Vector2(0, _mass * _gravityScale) * direction * Time.deltaTime;
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
}
