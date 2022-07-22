using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShotImitation : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [Header("AudioClip")]
    [SerializeField] private AudioClip _shotAudioClip;
    [SerializeField] private AudioClip _shotNoAmmoAudioClip;
    [SerializeField] private AudioClip _carAccident;
    [SerializeField] private AudioClip _carAccidentGround;
    [SerializeField] private AudioClip _comeHere;
    [SerializeField] private AudioClip _savaMe;


    private void Awake()
    {
        //_audioSource = GetComponentInChildren<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Shot();
    }

    public void Shot()
    {
        _audioSource.clip = _shotAudioClip;
        _audioSource.Play();
    }

    public void ShotNoAmmo()
    {
        _audioSource.clip = _shotNoAmmoAudioClip;
        _audioSource.Play();
    }

    public void CarAccident()
    {
        _audioSource.clip = _carAccident;
        _audioSource.Play();
    }

    public void ComeHere()
    {
        _audioSource.clip = _comeHere;
        _audioSource.Play();
    }

    public void CarAccidentGround()
    {
        _audioSource.clip = _carAccidentGround;
        _audioSource.Play();
    }

    public void SavaMe()
    {
        _audioSource.clip = _savaMe;
        _audioSource.Play();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("ClothingStore");
    }
}
