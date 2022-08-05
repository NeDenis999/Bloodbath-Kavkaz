using UnityEngine;

namespace Enemies
{
    public class EnemyStateBase : StateMachineBehaviour
    {
        private Terrorist terrorist;
        
        public Terrorist GetTerrorist(Animator animator)
        {
            if (!terrorist)
                terrorist = animator.GetComponentInParent<Terrorist>();
            
            return terrorist;
        }
    }
}