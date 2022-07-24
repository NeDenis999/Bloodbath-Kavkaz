using UnityEngine;

namespace Heroes
{
    public class HeroAnimator : MonoBehaviour
    {
        private static readonly int JumpHash = Animator.StringToHash("Jump");
        private static readonly int HorizontalHash = Animator.StringToHash("Horizontal");
        
        [SerializeField] 
        private Animator _animator;
        
        public void Move(float direction)
        {
            //_spriteRenderer.flipX = direction < 0;
            _animator.SetFloat(HorizontalHash, 1);
        }

        public void Stand() => 
            _animator.SetFloat(HorizontalHash, 0);
    }
}