using System.Collections;
using UnityEngine;

namespace Levels.ClothingStore
{
    public class Grenade : MonoBehaviour
    {
        [SerializeField] 
        private Explosion _explosion;
        
        public void Explosion()
        {
            _explosion.PlayEffect();
        }
    }
}