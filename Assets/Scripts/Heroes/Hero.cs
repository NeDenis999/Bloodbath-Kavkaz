using UnityEngine;

namespace Heroes
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] 
        private MonoBehaviour[] _monoBehaviours;
        
        public void TimeDilation(float timeScale)
        {
            Time.timeScale = timeScale;
        }

        public void Pause()
        {
            foreach (var monoBehaviour in _monoBehaviours) 
                monoBehaviour.enabled = false;
        }
        
        public void UnPause()
        {
            foreach (var monoBehaviour in _monoBehaviours) 
                monoBehaviour.enabled = true;
        }
    }
}
