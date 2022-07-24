using UnityEngine;

namespace Heroes
{
    public class KeyboardInput : MonoBehaviour
    {
        private const string Horizontal = "Horizontal";
        private const string Jump = "Jump";
        private const string Ability = "Ability";
        
        [SerializeField] 
        private HeroMovement _movement;
        
        [SerializeField]
        private Hero hero;

        private float _horizontal;

        private void Update()
        {
            _horizontal = Input.GetAxisRaw(Horizontal);

            if (Input.GetButtonDown(Jump))
                _movement.TryJump();

            if (_horizontal != 0)
                _movement.TryMove(_horizontal);
            else
                _movement.Stand();

            if (Input.GetButtonDown(Ability))
                hero.TimeDilation(0.5f);

            if (Input.GetButtonUp(Ability))
                hero.TimeDilation(1f);
        }
    }
}
