using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManager : MonoBehaviour
{
    [SerializeField] public AudioClip CityAmbianceSFX, ForestAmbianceSFX, MainMenuSFX, ChatterInBarSFX, discoSFX, skateSFX;
    AudioSource audioSource;
    public bool city = false;
    public bool forest = false;
    public bool mainMenu = false;
    public bool chatterBar = false;
    public bool disco = false;
    public bool skate = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (city)
        {
            audioSource.clip = CityAmbianceSFX;
            audioSource.Play();
        }
        if (forest)
        {
            audioSource.clip = ForestAmbianceSFX;
            audioSource.Play();
        }
        if (mainMenu)
        {
            audioSource.clip = MainMenuSFX;
            audioSource.Play();
        }
        if (chatterBar)
        {
            audioSource.clip = ChatterInBarSFX;
            audioSource.Play();
        }
        if (disco)
        {
            audioSource.clip = discoSFX;
            audioSource.Play();
        }
        if (skate)
        {
            audioSource.clip = skateSFX;
            audioSource.Play();
        }
    }
}
