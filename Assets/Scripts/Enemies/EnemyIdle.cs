using UnityEngine;
using UnityEngine.Animations;

namespace Enemies
{
    public class EnemyIdle : EnemyStateBase
    {
        private static readonly int EndIdle = Animator.StringToHash("EndIdle");

        [SerializeField]
        private float _stoppingTime;

        private float _currentStoppingTime;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex,
            AnimatorControllerPlayable controller)
        {
            
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex,
            AnimatorControllerPlayable controller)
        {
            Debug.Log("EnemyIdle");
            
            if (CountingDown())
                animator.SetTrigger(EndIdle);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex,
            AnimatorControllerPlayable controller)
        {
            
        }

        private bool CountingDown()
        {
            if (_currentStoppingTime > _stoppingTime)
            {
                _currentStoppingTime = 0;
                return true;
            }

            _currentStoppingTime += Time.deltaTime;
            return false;
        }
    }
}