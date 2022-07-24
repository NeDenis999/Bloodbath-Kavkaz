using UnityEngine;

namespace Heroes
{
    public class HeroMovement : MonoBehaviour
    {
        private readonly Vector2 MoveVectorDefault = new Vector2(2, 0);
        
        [SerializeField] 
        private Rigidbody2D _rigidbody2D;

        [SerializeField] 
        private float _jumpForce;

        [SerializeField] 
        private float _gravitySpeed;
        
        [SerializeField] 
        private float _speedRunPlayer;
                
        [SerializeField] 
        private float _speedJumpPlayer;

        [SerializeField] 
        private SurfaceSlider _surfaceSlider;

        [SerializeField] 
        private HeroAnimator _heroAnimator;
        
        private bool _isJump;
        private bool _isGrounded;
        private Vector2 _moveVectorForPlayer;

        private void FixedUpdate()
        {
            if (!_isGrounded)
                GravityMove();
        }

        public void TryMove(float horizontal)
        {
            Move(horizontal);
        }

        public void TryJump()
        {
            if (!_isJump && _isGrounded)
                Jump();
        }
        
        private void Jump()
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _isJump = true;
        }

        private void GravityMove() => 
            _rigidbody2D.velocity += new Vector2(0, -_gravitySpeed);

        public void Landing()
        {
            if (_rigidbody2D.velocity.y < 0 && !_isGrounded)
                _rigidbody2D.velocity = Vector2.zero;
            
            _isGrounded = true;
            _isJump = false;
        }

        public void Fall() => 
            _isGrounded = false;

        private void Move(float horizontal)
        {
            if (!_isJump && _isGrounded)
            {
                UpdateDirection(horizontal);
                _moveVectorForPlayer *= _speedRunPlayer;
            }
            else
            {
                _moveVectorForPlayer = MoveVectorDefault * horizontal;
                _moveVectorForPlayer *= _speedJumpPlayer;
            }

            _heroAnimator.Move(horizontal);
            _rigidbody2D.position += _moveVectorForPlayer;
        }

        private void UpdateDirection(float horizontal) => 
            _moveVectorForPlayer = _surfaceSlider.Project(new Vector2(horizontal, 0));

        public void Stand() => 
            _heroAnimator.Stand();
    }
}
