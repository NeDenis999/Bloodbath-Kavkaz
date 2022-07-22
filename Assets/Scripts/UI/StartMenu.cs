using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using TMPro;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private AudioSource _music;
    [SerializeField] private TextMeshProUGUI _textButtonStartGame;

    [Header("Screen")]
    [SerializeField] private GameObject _settingMenuScreen;
    [SerializeField] private GameObject _startMenuScreen;

    [Header("Button")]
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _settingMenuCloseButton;
    [SerializeField] private Button _settingMenuOpenButton;
    [SerializeField] private Button _exitGameButton;

    private void OnEnable()
    {
        _startGameButton.onClick.AddListener(OnStartGameClick);
        _settingMenuCloseButton.onClick.AddListener(OnSettingMenuOpenClick);
        _settingMenuOpenButton.onClick.AddListener(OnSettingMenuCloseClick);
        _exitGameButton.onClick.AddListener(OnExitClick);
    }

    private void OnDisable()
    {
        _startGameButton.onClick.RemoveListener(OnStartGameClick);
        _settingMenuCloseButton.onClick.RemoveListener(OnSettingMenuOpenClick);
        _settingMenuOpenButton.onClick.RemoveListener(OnSettingMenuCloseClick);
        _exitGameButton.onClick.RemoveListener(OnExitClick);
    }

    private void Start()
    {
        _textButtonStartGame.text = "Начать игру";
        //_textButtonStartGame.text = "Продолжить";
    }

    public async void OnStartGameClick()
    {
        _background.gameObject.SetActive(true);
        float alpha = 0f;

        foreach (var animator in GetComponentsInChildren<Animator>())
        {
            animator.enabled = false;
        }

        while (alpha < 1)
        {
            await Task.Delay(10);
            alpha += 0.01f;
            _music.volume = 1 - alpha;
            _background.color = new Color(0f, 0f, 0f, alpha);
        }

        await Task.Delay(600);
        SceneManager.LoadScene("SplashScreen");
    }

    public void OnSettingMenuOpenClick()
    {
        _startMenuScreen.SetActive(false);
        _settingMenuScreen.SetActive(true);
    }

    public void OnSettingMenuCloseClick()
    {
        _settingMenuScreen.SetActive(false);
        _startMenuScreen.SetActive(true);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
