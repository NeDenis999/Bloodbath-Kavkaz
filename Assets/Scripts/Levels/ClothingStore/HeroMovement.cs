using Heroes;
using UnityEngine;

namespace Levels.ClothingStore
{
    public class HeroMovement : MonoBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody2D;

        [SerializeField] 
        private float _speedRunPlayer;

        [SerializeField] 
        private SurfaceSlider _surfaceSlider;

        [SerializeField] 
        private HeroAnimator _heroAnimator;
        
        private Vector2 _moveVectorForPlayer;

        public void TryMove(float horizontal)
        {
            Move(horizontal);
        }

        private void Move(float horizontal)
        {
            UpdateDirection(horizontal);
            _moveVectorForPlayer *= _speedRunPlayer;
            _heroAnimator.Move(horizontal);
            _rigidbody2D.position += _moveVectorForPlayer;
        }

        private void UpdateDirection(float horizontal) => 
            _moveVectorForPlayer = _surfaceSlider.Project(new Vector2(horizontal, 0));

        public void Stand() => 
            _heroAnimator.Stand();
    }
}