using UnityEngine;
using UnityEngine.Animations;

namespace Enemies
{
    public class EnemyWalk : EnemyStateBase
    {
        private static readonly int EndMove = Animator.StringToHash("EndMove");

        [SerializeField]
        private float _speed;

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
            Debug.Log("EnemyWalk");
            Move(GetTerrorist(animator).transform);
            
            if (CountingDown())
                animator.SetTrigger(EndMove);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex,
            AnimatorControllerPlayable controller)
        {
            
        }

        public void Move(Transform transform) => 
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        
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