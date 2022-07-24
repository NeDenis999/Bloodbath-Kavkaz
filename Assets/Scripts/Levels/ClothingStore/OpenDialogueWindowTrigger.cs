using Heroes;
using UnityEngine;

namespace Levels.ClothingStore
{
    public class OpenDialogueWindowTrigger : MonoBehaviour
    {
        [SerializeField] 
        private DialogueWindow dialogueWindow;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Hero hero))
            {
                hero.Pause();
                hero.GetComponent<HeroAnimator>().Stand();
                dialogueWindow.Show();
                gameObject.SetActive(false);
            }
        }
    }
}