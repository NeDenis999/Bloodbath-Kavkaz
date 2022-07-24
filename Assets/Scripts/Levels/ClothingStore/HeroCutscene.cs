using System.Collections;
using Heroes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Levels.ClothingStore
{
    public class HeroCutscene : MonoBehaviour
    {
        private const string HospitalScenePath = "Hospital";
        
        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        [SerializeField] 
        private SpriteRenderer _spriteRenderer;
        
        [SerializeField] 
        private Vector2 _force;
        
        [SerializeField] 
        private Sprite[] _sprites;

        [SerializeField] 
        private Hero _hero;
        
        public void StartDeadExplosion()
        {
            gameObject.SetActive(true);
            StartCoroutine(DeadExplosion());
        }

        private IEnumerator DeadExplosion()
        {
            transform.position = _hero.transform.position;
            _hero.gameObject.SetActive(false);
            _rigidbody2D.AddForce(_force, ForceMode2D.Impulse);
            _spriteRenderer.sprite = _sprites[0];
            yield return new WaitForSeconds(0.5f);
            _spriteRenderer.sprite = _sprites[1];
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(HospitalScenePath);
        }
    }
}