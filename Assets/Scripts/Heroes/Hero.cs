using UnityEngine;

namespace Heroes
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] 
        private KeyboardInput _keyboardInput;
        
        [SerializeField] 
        private HeroAnimator _heroAnimator;

        [SerializeField] 
        private HeroMovement _heroMovement;

        [SerializeField] 
        private DirectionAim _directionAim;

        public void TimeDilation(float timeScale)
        {
            Time.timeScale = timeScale;
        }

        public void Pause()
        {
            _keyboardInput.enabled = false;
            _heroAnimator.enabled = false;
            _heroMovement.enabled = false;
            _directionAim.enabled = false;
        }
        
        public void UnPause()
        {
            _keyboardInput.enabled = true;
            _heroAnimator.enabled = true;
            _heroMovement.enabled = true;
            _directionAim.enabled = true;
        }
    }
}
