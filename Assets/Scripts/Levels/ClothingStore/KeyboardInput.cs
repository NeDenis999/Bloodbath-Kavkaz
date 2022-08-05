using UnityEngine;

namespace Levels.ClothingStore
{
    public class KeyboardInput : MonoBehaviour
    {
        private const string Horizontal = "Horizontal";

        [SerializeField] 
        private HeroMovement _movement;
        
        private float _horizontal;

        private void Update()
        {
            _horizontal = Input.GetAxisRaw(Horizontal);

            if (_horizontal != 0)
                _movement.TryMove(_horizontal);
            else
                _movement.Stand();
        }
    }
}