using UnityEngine;

namespace Levels.ClothingStore
{
    public class HeroDeadExplosion : MonoBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody2D;

        [SerializeField] 
        private Animator _animator;
        
        [SerializeField] 
        private Vector2 _force;
        
        public void Explosion()
        {
            _rigidbody2D.AddForce(_force, ForceMode2D.Impulse);
        }
    }
}