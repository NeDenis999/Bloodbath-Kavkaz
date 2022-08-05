using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Levels.Disclaimer
{
    public class DisclaimerWindow : MonoBehaviour
    {
        private const string StartMenuScenePath = "StartMenu";

        private IEnumerator Start()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(StartMenuScenePath);
        }
    }
}