using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Levels.ClothingStore
{
    public class Terrorist : MonoBehaviour
    {
        [SerializeField] 
        private Sprite _deadSprite;

        [SerializeField] 
        private SpriteRenderer _spriteRenderer;

        [SerializeField] 
        private Grenade _grenade;

        [SerializeField] 
        private Vector2 _force;

        [SerializeField] 
        private HeroCutscene _heroCutscene;
        
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _rigidbody2D = _grenade.GetComponent<Rigidbody2D>();
        }

        public void Cast()
        {
            _rigidbody2D.constraints = RigidbodyConstraints2D.None;
            _rigidbody2D.AddForce(_force, ForceMode2D.Impulse);

            StartCoroutine(BeforeExplosion());
        }

        private void Dead() => 
            _spriteRenderer.sprite = _deadSprite;

        private IEnumerator BeforeExplosion()
        {
            yield return new WaitForSeconds(1.5f);
            Dead();
            _heroCutscene.StartDeadExplosion();
            _grenade.Explosion();
            _grenade.gameObject.SetActive(false);
        }
    }
}